using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MenmenGoldenHouse.Core.Entities;
using MenmenGoldenHouse.Data.Context;

namespace MenmenGoldenHouse.Api.Controllers;

/// <summary>
/// API endpoints for course management
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class CoursesController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly ILogger<CoursesController> _logger;

    public CoursesController(AppDbContext context, ILogger<CoursesController> logger)
    {
        _context = context;
        _logger = logger;
    }

    /// <summary>
    /// Get all courses
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CourseDto>>> GetCourses()
    {
        try
        {
            var courses = await _context.Courses
                .Include(c => c.Chapters)
                .OrderByDescending(c => c.CreatedAt)
                .ToListAsync();

            var courseDtos = courses.Select(c => new CourseDto
            {
                Id = c.Id,
                Title = c.Title,
                Description = c.Description,
                ImageUrl = c.ImageUrl,
                ChapterCount = c.Chapters.Count,
                CreatedAt = c.CreatedAt
            }).ToList();

            return Ok(courseDtos);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving courses");
            return StatusCode(500, "Error retrieving courses");
        }
    }

    /// <summary>
    /// Get a specific course with its chapters
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ActionResult<CourseDetailDto>> GetCourse(int id)
    {
        try
        {
            var course = await _context.Courses
                .Include(c => c.Chapters)
                .ThenInclude(ch => ch.Documents)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (course == null)
            {
                return NotFound("Course not found");
            }

            var courseDto = new CourseDetailDto
            {
                Id = course.Id,
                Title = course.Title,
                Description = course.Description,
                ImageUrl = course.ImageUrl,
                CreatedAt = course.CreatedAt,
                Chapters = course.Chapters.Select(ch => new ChapterDto
                {
                    Id = ch.Id,
                    Title = ch.Title,
                    OrderNumber = ch.OrderNumber,
                    DocumentCount = ch.Documents.Count
                }).OrderBy(ch => ch.OrderNumber).ToList()
            };

            return Ok(courseDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving course {CourseId}", id);
            return StatusCode(500, "Error retrieving course");
        }
    }

    /// <summary>
    /// Create a new course
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<CourseDto>> CreateCourse([FromBody] CreateCourseRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Title))
        {
            return BadRequest("Course title is required");
        }

        try
        {
            var course = new Course
            {
                Title = request.Title,
                Description = request.Description ?? string.Empty,
                ImageUrl = request.ImageUrl,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _context.Courses.Add(course);
            await _context.SaveChangesAsync();

            var courseDto = new CourseDto
            {
                Id = course.Id,
                Title = course.Title,
                Description = course.Description,
                ImageUrl = course.ImageUrl,
                ChapterCount = 0,
                CreatedAt = course.CreatedAt
            };

            return CreatedAtAction(nameof(GetCourse), new { id = course.Id }, courseDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error creating course");
            return StatusCode(500, "Error creating course");
        }
    }

    /// <summary>
    /// Update a course
    /// </summary>
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCourse(int id, [FromBody] UpdateCourseRequest request)
    {
        try
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound("Course not found");
            }

            if (!string.IsNullOrWhiteSpace(request.Title))
                course.Title = request.Title;
            if (!string.IsNullOrWhiteSpace(request.Description))
                course.Description = request.Description;
            if (request.ImageUrl != null)
                course.ImageUrl = request.ImageUrl;

            course.UpdatedAt = DateTime.UtcNow;

            _context.Courses.Update(course);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error updating course {CourseId}", id);
            return StatusCode(500, "Error updating course");
        }
    }

    /// <summary>
    /// Delete a course
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCourse(int id)
    {
        try
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound("Course not found");
            }

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error deleting course {CourseId}", id);
            return StatusCode(500, "Error deleting course");
        }
    }
}

// DTOs
public class CourseDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public int ChapterCount { get; set; }
    public DateTime CreatedAt { get; set; }
}

public class CourseDetailDto : CourseDto
{
    public List<ChapterDto> Chapters { get; set; } = new();
}

public class ChapterDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int OrderNumber { get; set; }
    public int DocumentCount { get; set; }
}

public class CreateCourseRequest
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
}

public class UpdateCourseRequest
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
}
