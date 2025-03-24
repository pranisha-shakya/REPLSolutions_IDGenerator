using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class VoucherEntry
{
    public int Id { get; set; }

    public int VoucherType { get; set; }

    public int Number { get; set; }

    public string? ExternalReference { get; set; }

    public int ExternalReferenceType { get; set; }

    public string? ExternalReferenceTypeText { get; set; }

    public int TransactionType { get; set; }

    public decimal Amount { get; set; }

    public int? ParentVoucherEntryId { get; set; }

    public string? Narration { get; set; }

    public string? Reference { get; set; }

    public string? AgainstReference { get; set; }

    public int? PaymentMethod { get; set; }

    public string? PaymentReference { get; set; }

    public DateTimeOffset Date { get; set; }

    public DateTimeOffset CreatedDate { get; set; }

    public virtual ICollection<VoucherEntry> InverseParentVoucherEntry { get; set; } = new List<VoucherEntry>();

    public virtual ICollection<LedgerStatement> LedgerStatements { get; set; } = new List<LedgerStatement>();

    public virtual VoucherEntry? ParentVoucherEntry { get; set; }

    public virtual ICollection<VoucherEntryDetail> VoucherEntryDetails { get; set; } = new List<VoucherEntryDetail>();
}
