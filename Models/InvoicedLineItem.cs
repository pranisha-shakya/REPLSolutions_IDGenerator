using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class InvoicedLineItem
{
    public int Id { get; set; }

    public int InvoiceId { get; set; }

    public string InvoiceNumber { get; set; } = null!;

    public int QueuedLineItemId { get; set; }

    public decimal Amount { get; set; }

    public DateTimeOffset RevisedStartDate { get; set; }

    public DateTimeOffset AddedDate { get; set; }

    public bool IsInvoiceable { get; set; }

    public string? Note { get; set; }

    public DateTimeOffset AppliedStartDate { get; set; }

    public virtual Invoice Invoice { get; set; } = null!;

    public virtual ICollection<InvoicedLineItemPayment> InvoicedLineItemPayments { get; set; } = new List<InvoicedLineItemPayment>();

    public virtual QueuedLineItem QueuedLineItem { get; set; } = null!;
}
