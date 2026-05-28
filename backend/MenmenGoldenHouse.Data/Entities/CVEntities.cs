namespace MenmenGoldenHouse.Core.Entities;

/// <summary>
/// Represents a portfolio project
/// </summary>
public class Project
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public string? GitHubUrl { get; set; }
    public string? DemoUrl { get; set; }
    public string TechStack { get; set; } = string.Empty; // JSON or comma-separated
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    // Navigation
    public ICollection<ProjectTag> Tags { get; set; } = new List<ProjectTag>();
}

/// <summary>
/// Tags for categorizing projects
/// </summary>
public class ProjectTag
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public string TagName { get; set; } = string.Empty;

    // Foreign key and navigation
    public Project? Project { get; set; }
}

/// <summary>
/// Represents work experience
/// </summary>
public class Experience
{
    public int Id { get; set; }
    public string Company { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsCurrentPosition { get; set; }
    public int OrderNumber { get; set; }
}

/// <summary>
/// Represents education
/// </summary>
public class Education
{
    public int Id { get; set; }
    public string School { get; set; } = string.Empty;
    public string Degree { get; set; } = string.Empty;
    public string Major { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int OrderNumber { get; set; }
}

/// <summary>
/// Represents a skill
/// </summary>
public class Skill
{
    public int Id { get; set; }
    public string SkillName { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty; // Backend, Frontend, DevOps, etc.
    public int Proficiency { get; set; } = 50; // 0-100
    public int OrderNumber { get; set; }
}
