namespace MenmenGoldenHouse.Core.Entities;

/// <summary>
/// Represents a photo in the gallery with timestamp
/// </summary>
public class Photo
{
    public int Id { get; set; }
    public string FileName { get; set; } = string.Empty;
    public string FileUrl { get; set; } = string.Empty;
    public long FileSizeBytes { get; set; }
    public string? Description { get; set; }
    
    /// <summary>
    /// The date this photo belongs to (photo diary date)
    /// </summary>
    public DateOnly PhotoDate { get; set; }
    
    public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
