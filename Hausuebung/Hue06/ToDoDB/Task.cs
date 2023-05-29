using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToDoShared;

[Table("task")]
[Index("Id", IsUnique = true)]
public partial class Task
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("summary")]
    public string? Summary { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("creation_date")]
    public string? CreationDate { get; set; }

    [Column("due_date")]
    public string? DueDate { get; set; }

    [Column("priority")]
    public long? Priority { get; set; }

    [Column("status")]
    public long? Status { get; set; }

    [ForeignKey("Priority")]
    [InverseProperty("Tasks")]
    public virtual Priority? PriorityNavigation { get; set; }

    [ForeignKey("Status")]
    [InverseProperty("Tasks")]
    public virtual Status? StatusNavigation { get; set; }
}
