using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ChinookShared;

[Table("invoices")]
[Index("CustomerId", Name = "IFK_InvoiceCustomerId")]
public partial class Invoice
{
    [Key]
    public long InvoiceId { get; set; }

    public long CustomerId { get; set; }

    [Column(TypeName = "DATETIME")]
    public byte[] InvoiceDate { get; set; } = null!;

    [Column(TypeName = "NVARCHAR(70)")]
    public string? BillingAddress { get; set; }

    [Column(TypeName = "NVARCHAR(40)")]
    public string? BillingCity { get; set; }

    [Column(TypeName = "NVARCHAR(40)")]
    public string? BillingState { get; set; }

    [Column(TypeName = "NVARCHAR(40)")]
    public string? BillingCountry { get; set; }

    [Column(TypeName = "NVARCHAR(10)")]
    public string? BillingPostalCode { get; set; }

    [Column(TypeName = "NUMERIC(10,2)")]
    public byte[] Total { get; set; } = null!;

    [ForeignKey("CustomerId")]
    [InverseProperty("Invoices")]
    public virtual Customer Customer { get; set; } = null!;

    [InverseProperty("Invoice")]
    public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();
}
