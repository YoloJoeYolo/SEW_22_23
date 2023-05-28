using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FarmerShared;

[Table("Field")]
public partial class Field
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    [Column("areaInHa", TypeName = "NUMERIC")]
    public byte[] AreaInHa { get; set; } = null!;

    [Column("farmerId")]
    public long FarmerId { get; set; }

    [ForeignKey("FarmerId")]
    [InverseProperty("Fields")]
    public virtual Farmer Farmer { get; set; } = null!;
}
