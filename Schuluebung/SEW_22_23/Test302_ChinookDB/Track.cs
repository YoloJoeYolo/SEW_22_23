using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ChinookShared;

[Table("tracks")]
[Index("AlbumId", Name = "IFK_TrackAlbumId")]
[Index("GenreId", Name = "IFK_TrackGenreId")]
[Index("MediaTypeId", Name = "IFK_TrackMediaTypeId")]
public partial class Track
{
    [Key]
    public long TrackId { get; set; }

    [Column(TypeName = "NVARCHAR(200)")]
    public string Name { get; set; } = null!;

    public long? AlbumId { get; set; }

    public long MediaTypeId { get; set; }

    public long? GenreId { get; set; }

    [Column(TypeName = "NVARCHAR(220)")]
    public string? Composer { get; set; }

    public long Milliseconds { get; set; }

    public long? Bytes { get; set; }

    [Column(TypeName = "NUMERIC(10,2)")]
    public byte[] UnitPrice { get; set; } = null!;

    [ForeignKey("AlbumId")]
    [InverseProperty("Tracks")]
    public virtual Album? Album { get; set; }

    [ForeignKey("GenreId")]
    [InverseProperty("Tracks")]
    public virtual Genre? Genre { get; set; }

    [InverseProperty("Track")]
    public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();

    [ForeignKey("MediaTypeId")]
    [InverseProperty("Tracks")]
    public virtual MediaType MediaType { get; set; } = null!;

    [ForeignKey("TrackId")]
    [InverseProperty("Tracks")]
    public virtual ICollection<Playlist> Playlists { get; set; } = new List<Playlist>();
}
