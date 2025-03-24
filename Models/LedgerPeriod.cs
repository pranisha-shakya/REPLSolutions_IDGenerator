using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class LedgerPeriod
{
    public int Id { get; set; }

    public decimal OpeningBalance { get; set; }

    public DateTimeOffset OpeningBalanceDate { get; set; }

    public decimal? ClosingBalance { get; set; }

    public DateTimeOffset? ClosingBalanceDate { get; set; }

    public int LedgerId { get; set; }

    public DateTimeOffset? TentativeClosingDate { get; set; }

    public virtual Ledger Ledger { get; set; } = null!;

    public virtual ICollection<LedgerStatement> LedgerStatements { get; set; } = new List<LedgerStatement>();
}
