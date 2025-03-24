using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Receipt
{
    public int Id { get; set; }

    public int InvoiceId { get; set; }

    public string Number { get; set; } = null!;

    public decimal Amount { get; set; }

    public string? Note { get; set; }

    public DateTimeOffset PaymentDate { get; set; }

    public string? PaymentReferenceNumber { get; set; }

    public int PaymentMethod { get; set; }

    public string? PaymentMethodText { get; set; }

    public DateTimeOffset CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string PaidBy { get; set; } = null!;

    public decimal PreviousBalanceAmount { get; set; }

    public decimal InvoicedLineItemsAmount { get; set; }

    public decimal AdjustedAmount { get; set; }

    public decimal PaidAmount { get; set; }

    public decimal PayableAmount { get; set; }

    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public string? DeletedById { get; set; }

    public string? ReasonForDeletion { get; set; }

    public DateTimeOffset? DeletedOn { get; set; }

    public decimal DeletedAmount { get; set; }

    public decimal DeletedAdjustedAmount { get; set; }

    public int? LedgerReference { get; set; }

    public virtual ICollection<FlatReceipt> FlatReceipts { get; set; } = new List<FlatReceipt>();

    public virtual Invoice Invoice { get; set; } = null!;

    public virtual ICollection<InvoicedLineItemPayment> InvoicedLineItemPayments { get; set; } = new List<InvoicedLineItemPayment>();
}
