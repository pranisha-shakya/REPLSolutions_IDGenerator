using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Ledger
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public int GroupId { get; set; }

    public int? ExternalReferenceType { get; set; }

    public string? ExternalReferenceTypeText { get; set; }

    public string? ExternalReference { get; set; }

    public virtual Group Group { get; set; } = null!;

    public virtual ICollection<LedgerPeriod> LedgerPeriods { get; set; } = new List<LedgerPeriod>();
}
