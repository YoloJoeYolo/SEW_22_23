using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchooldataShared;

[Table("Person")]
public partial class Person
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    public string Discriminator { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? HireDate { get; set; }

    public string? EnrollmentDate { get; set; }

    [InverseProperty("Instructor")]
    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    [InverseProperty("Student")]
    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    [InverseProperty("Instructor")]
    public virtual OfficeAssignment? OfficeAssignment { get; set; }

    [ForeignKey("InstructorId")]
    [InverseProperty("Instructors")]
    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
