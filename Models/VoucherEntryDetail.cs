using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class VoucherEntryDetail
{
    public int Id { get; set; }

    public int TransactionType { get; set; }

    public decimal Amount { get; set; }

    public int VoucherEntryId { get; set; }

    public string? Description { get; set; }

    public virtual VoucherEntry VoucherEntry { get; set; } = null!;
}
