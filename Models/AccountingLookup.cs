using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class AccountingLookup
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public string? Item { get; set; }

    public int? RefId { get; set; }

    public int? GroupId { get; set; }

    public string? GroupType { get; set; }

    public string? Remarks { get; set; }

    public decimal OpeningBalance { get; set; }
}
