using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchooldataShared;

[Table("Enrollment")]
[Index("CourseId", Name = "IX_Enrollment_CourseID")]
[Index("StudentId", Name = "IX_Enrollment_StudentID")]
public partial class Enrollment
{
    [Key]
    [Column("EnrollmentID")]
    public long EnrollmentId { get; set; }

    [Column("CourseID")]
    public long CourseId { get; set; }

    public long? Grade { get; set; }

    [Column("StudentID")]
    public long StudentId { get; set; }

    [ForeignKey("CourseId")]
    [InverseProperty("Enrollments")]
    public virtual Course Course { get; set; } = null!;

    [ForeignKey("StudentId")]
    [InverseProperty("Enrollments")]
    public virtual Person Student { get; set; } = null!;
}
