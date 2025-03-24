using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class FlatReceipt
{
    public int Id { get; set; }

    public int ReceiptNumber { get; set; }

    public bool IsRegisteredStudent { get; set; }

    public string? StudentName { get; set; }

    public string? Class { get; set; }

    public string? Section { get; set; }

    public string? RollNumber { get; set; }

    public string? PaymentFor { get; set; }

    public decimal Amount { get; set; }

    public string? Description { get; set; }

    public string? PaymentType { get; set; }

    public string? PaymentRefrenceNumber { get; set; }

    public string? SubLedger { get; set; }

    public string? Narration { get; set; }

    public DateTimeOffset DateofReceipt { get; set; }

    public int? AdmissionId { get; set; }

    public int? ReceiptId { get; set; }

    public DateTimeOffset Updatedon { get; set; }

    public string? UpdatedBy { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public string? DeletedById { get; set; }

    public string? ReasonForDeletion { get; set; }

    public DateTimeOffset? DeletedOn { get; set; }

    public decimal DeletedAmount { get; set; }

    public virtual Admission? Admission { get; set; }

    public virtual Receipt? Receipt { get; set; }
}
