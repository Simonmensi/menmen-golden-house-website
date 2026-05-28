using Microsoft.EntityFrameworkCore;
using MenmenGoldenHouse.Core.Entities;

namespace MenmenGoldenHouse.Data.Context;

/// <summary>
/// Main database context for Menmen's Golden House
/// </summary>
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // DbSets
    public DbSet<Course> Courses { get; set; } = null!;
    public DbSet<Chapter> Chapters { get; set; } = null!;
    public DbSet<CourseDocument> CourseDocuments { get; set; } = null!;
    public DbSet<Photo> Photos { get; set; } = null!;
    public DbSet<Project> Projects { get; set; } = null!;
    public DbSet<ProjectTag> ProjectTags { get; set; } = null!;
    public DbSet<Experience> Experiences { get; set; } = null!;
    public DbSet<Education> Educations { get; set; } = null!;
    public DbSet<Skill> Skills { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure relationships
        modelBuilder.Entity<Course>()
            .HasMany(c => c.Chapters)
            .WithOne(ch => ch.Course)
            .HasForeignKey(ch => ch.CourseId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Chapter>()
            .HasMany(ch => ch.Documents)
            .WithOne(d => d.Chapter)
            .HasForeignKey(d => d.ChapterId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Project>()
            .HasMany(p => p.Tags)
            .WithOne(t => t.Project)
            .HasForeignKey(t => t.ProjectId)
            .OnDelete(DeleteBehavior.Cascade);

        // Add indices for common queries
        modelBuilder.Entity<Photo>()
            .HasIndex(p => p.PhotoDate);

        modelBuilder.Entity<Course>()
            .HasIndex(c => c.CreatedAt);

        modelBuilder.Entity<Experience>()
            .HasIndex(e => e.OrderNumber);

        modelBuilder.Entity<Education>()
            .HasIndex(e => e.OrderNumber);

        modelBuilder.Entity<Skill>()
            .HasIndex(s => s.OrderNumber);
    }
}
