using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ChinookShared;

[Table("artists")]
public partial class Artist
{
    [Key]
    public long ArtistId { get; set; }

    [Column(TypeName = "NVARCHAR(120)")]
    public string? Name { get; set; }

    [InverseProperty("Artist")]
    public virtual ICollection<Album> Albums { get; set; } = new List<Album>();
}
