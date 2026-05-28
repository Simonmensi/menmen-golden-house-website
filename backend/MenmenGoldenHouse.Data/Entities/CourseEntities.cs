namespace MenmenGoldenHouse.Core.Entities;

/// <summary>
/// Represents a course/subject with chapters and documents
/// </summary>
public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public ICollection<Chapter> Chapters { get; set; } = new List<Chapter>();
}

/// <summary>
/// Represents a chapter within a course
/// </summary>
public class Chapter
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public string Title { get; set; } = string.Empty;
    public int OrderNumber { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    // Foreign key and navigation
    public Course? Course { get; set; }
    public ICollection<CourseDocument> Documents { get; set; } = new List<CourseDocument>();
}

/// <summary>
/// Represents a document (file) within a chapter
/// </summary>
public class CourseDocument
{
    public int Id { get; set; }
    public int ChapterId { get; set; }
    public string FileName { get; set; } = string.Empty;
    public string FileType { get; set; } = string.Empty; // pdf, docx, jpg, etc.
    public string FileUrl { get; set; } = string.Empty;
    public long FileSizeBytes { get; set; }
    public string? Description { get; set; }
    public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

    // Foreign key and navigation
    public Chapter? Chapter { get; set; }
}
