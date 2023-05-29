using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToDoShared;

[Table("status")]
[Index("Id", IsUnique = true)]
[Index("Status1", IsUnique = true)]
public partial class Status
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("status")]
    public string Status1 { get; set; } = null!;

    [InverseProperty("StatusNavigation")]
    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
