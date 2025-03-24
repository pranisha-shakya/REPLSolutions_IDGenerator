using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Invoice
{
    public int Id { get; set; }

    public int AdmissionId { get; set; }

    public string Number { get; set; } = null!;

    public string Period { get; set; } = null!;

    public string? Note { get; set; }

    public int InvoiceStatus { get; set; }

    public string? InvoiceStatusText { get; set; }

    public string? CreatedBy { get; set; }

    public DateTimeOffset CreatedDate { get; set; }

    public string? CancelledBy { get; set; }

    public DateTimeOffset? CancelledDate { get; set; }

    public string? CancellationReason { get; set; }

    public DateTimeOffset DueDate { get; set; }

    public decimal PreviousBalance { get; set; }

    public Guid BatchId { get; set; }

    public string? BatchName { get; set; }

    public bool IsInstant { get; set; }

    public virtual ICollection<Adjustment> Adjustments { get; set; } = new List<Adjustment>();

    public virtual Admission Admission { get; set; } = null!;

    public virtual ICollection<InvoicedLineItem> InvoicedLineItems { get; set; } = new List<InvoicedLineItem>();

    public virtual ICollection<Receipt> Receipts { get; set; } = new List<Receipt>();
}
