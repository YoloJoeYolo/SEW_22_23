using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchooldataShared;

[Table("Course")]
[Index("DepartmentId", Name = "IX_Course_DepartmentID")]
public partial class Course
{
    [Key]
    [Column("CourseID")]
    public long CourseId { get; set; }

    public long Credits { get; set; }

    [Column("DepartmentID")]
    public long DepartmentId { get; set; }

    public string? Title { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("Courses")]
    public virtual Department Department { get; set; } = null!;

    [InverseProperty("Course")]
    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    [ForeignKey("CourseId")]
    [InverseProperty("Courses")]
    public virtual ICollection<Person> Instructors { get; set; } = new List<Person>();
}
