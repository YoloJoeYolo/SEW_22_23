using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ChinookShared;

[Table("media_types")]
public partial class MediaType
{
    [Key]
    public long MediaTypeId { get; set; }

    [Column(TypeName = "NVARCHAR(120)")]
    public string? Name { get; set; }

    [InverseProperty("MediaType")]
    public virtual ICollection<Track> Tracks { get; set; } = new List<Track>();
}
