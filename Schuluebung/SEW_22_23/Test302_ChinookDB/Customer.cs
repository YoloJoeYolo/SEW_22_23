using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ChinookShared;

[Table("customers")]
[Index("SupportRepId", Name = "IFK_CustomerSupportRepId")]
public partial class Customer
{
    [Key]
    public long CustomerId { get; set; }

    [Column(TypeName = "NVARCHAR(40)")]
    public string FirstName { get; set; } = null!;

    [Column(TypeName = "NVARCHAR(20)")]
    public string LastName { get; set; } = null!;

    [Column(TypeName = "NVARCHAR(80)")]
    public string? Company { get; set; }

    [Column(TypeName = "NVARCHAR(70)")]
    public string? Address { get; set; }

    [Column(TypeName = "NVARCHAR(40)")]
    public string? City { get; set; }

    [Column(TypeName = "NVARCHAR(40)")]
    public string? State { get; set; }

    [Column(TypeName = "NVARCHAR(40)")]
    public string? Country { get; set; }

    [Column(TypeName = "NVARCHAR(10)")]
    public string? PostalCode { get; set; }

    [Column(TypeName = "NVARCHAR(24)")]
    public string? Phone { get; set; }

    [Column(TypeName = "NVARCHAR(24)")]
    public string? Fax { get; set; }

    [Column(TypeName = "NVARCHAR(60)")]
    public string Email { get; set; } = null!;

    public long? SupportRepId { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [ForeignKey("SupportRepId")]
    [InverseProperty("Customers")]
    public virtual Employee? SupportRep { get; set; }
}
