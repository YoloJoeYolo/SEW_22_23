using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NorthwindShared;

[Keyless]
public partial class EmployeeTerritory
{
    [Column("EmployeeID", TypeName = "INT")]
    public long EmployeeId { get; set; }

    [Column("TerritoryID", TypeName = "nvarchar] (20")]
    public string TerritoryId { get; set; } = null!;
}
