using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FarmerShared;

[Table("Farmer")]
public partial class Farmer
{
    [Key]
    public long Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Birthday { get; set; } = null!;

    [InverseProperty("Farmer")]
    public virtual ICollection<Field> Fields { get; set; } = new List<Field>();
}
