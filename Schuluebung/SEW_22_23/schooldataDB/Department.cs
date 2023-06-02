using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchooldataShared;

[Table("Department")]
[Index("InstructorId", Name = "IX_Department_InstructorID")]
public partial class Department
{
    [Key]
    [Column("DepartmentID")]
    public long DepartmentId { get; set; }

    [Column(TypeName = "money")]
    public byte[] Budget { get; set; } = null!;

    [Column("InstructorID")]
    public long? InstructorId { get; set; }

    public string? Name { get; set; }

    public byte[]? RowVersion { get; set; }

    public string StartDate { get; set; } = null!;

    [InverseProperty("Department")]
    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    [ForeignKey("InstructorId")]
    [InverseProperty("Departments")]
    public virtual Person? Instructor { get; set; }
}
