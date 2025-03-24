using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Adjustment
{
    public int Id { get; set; }

    public int InvoiceId { get; set; }

    public decimal Amount { get; set; }

    public string? Note { get; set; }

    public DateTimeOffset AdjustmentDate { get; set; }

    public DateTimeOffset CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public int? Type { get; set; }

    public int? ReceiptReference { get; set; }

    public virtual Invoice Invoice { get; set; } = null!;
}
