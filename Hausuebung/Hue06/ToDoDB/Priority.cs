using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToDoShared;

[Table("priority")]
[Index("Id", IsUnique = true)]
[Index("Priority1", IsUnique = true)]
public partial class Priority
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("priority")]
    public string Priority1 { get; set; } = null!;

    [InverseProperty("PriorityNavigation")]
    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
