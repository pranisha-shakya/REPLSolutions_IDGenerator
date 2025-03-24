using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class LedgerStatement
{
    public int Id { get; set; }

    public int LedgerPeriodId { get; set; }

    public int VoucherEntryId { get; set; }

    public virtual LedgerPeriod LedgerPeriod { get; set; } = null!;

    public virtual VoucherEntry VoucherEntry { get; set; } = null!;
}
