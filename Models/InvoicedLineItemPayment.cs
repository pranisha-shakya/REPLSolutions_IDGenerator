using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class InvoicedLineItemPayment
{
    public int Id { get; set; }

    public int InvoicedLineItemId { get; set; }

    public int ReceiptId { get; set; }

    public DateTimeOffset AllocationDate { get; set; }

    public string? AllocatedBy { get; set; }

    public string? ProcessedBy { get; set; }

    public decimal Amount { get; set; }

    public virtual InvoicedLineItem InvoicedLineItem { get; set; } = null!;

    public virtual Receipt Receipt { get; set; } = null!;
}
