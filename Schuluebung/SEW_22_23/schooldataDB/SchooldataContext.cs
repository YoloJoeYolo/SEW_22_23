using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SchooldataShared;

public partial class SchooldataContext : DbContext
{
    public SchooldataContext()
    {
    }

    public SchooldataContext(DbContextOptions<SchooldataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<OfficeAssignment> OfficeAssignments { get; set; }

    public virtual DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Filename=db/schooldata.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.Property(e => e.CourseId).ValueGeneratedNever();

            entity.HasMany(d => d.Instructors).WithMany(p => p.Courses)
                .UsingEntity<Dictionary<string, object>>(
                    "CourseAssignment",
                    r => r.HasOne<Person>().WithMany().HasForeignKey("InstructorId"),
                    l => l.HasOne<Course>().WithMany().HasForeignKey("CourseId"),
                    j =>
                    {
                        j.HasKey("CourseId", "InstructorId");
                        j.ToTable("CourseAssignment");
                        j.HasIndex(new[] { "InstructorId" }, "IX_CourseAssignment_InstructorID");
                        j.IndexerProperty<long>("CourseId").HasColumnName("CourseID");
                        j.IndexerProperty<long>("InstructorId").HasColumnName("InstructorID");
                    });
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasOne(d => d.Instructor).WithMany(p => p.Departments).OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OfficeAssignment>(entity =>
        {
            entity.Property(e => e.InstructorId).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
