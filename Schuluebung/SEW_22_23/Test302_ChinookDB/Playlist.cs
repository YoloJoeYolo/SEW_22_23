using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ChinookShared;

[Table("playlists")]
public partial class Playlist
{
    [Key]
    public long PlaylistId { get; set; }

    [Column(TypeName = "NVARCHAR(120)")]
    public string? Name { get; set; }

    [ForeignKey("PlaylistId")]
    [InverseProperty("Playlists")]
    public virtual ICollection<Track> Tracks { get; set; } = new List<Track>();
}
