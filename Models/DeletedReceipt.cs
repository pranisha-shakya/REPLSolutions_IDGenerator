using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class DeletedReceipt
{
    public int Id { get; set; }

    public int ReceiptId { get; set; }

    public string? Values { get; set; }

    public int AdmissionId { get; set; }

    public string? ClassroomName { get; set; }

    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public string? DeletedBy { get; set; }

    public string? ReasonForDeletion { get; set; }

    public DateTimeOffset? DeletedOn { get; set; }

    public decimal DeletedAmount { get; set; }

    public decimal DeletedAdjustedAmount { get; set; }
}
