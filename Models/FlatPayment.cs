using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class FlatPayment
{
    public int Id { get; set; }

    public string? ByParticularLedger { get; set; }

    public string? ByDescription { get; set; }

    public decimal DebitAmount { get; set; }

    public string? ToParticularLedger { get; set; }

    public string? ToDescription { get; set; }

    public decimal CreditAmount { get; set; }

    public string? ChequeNumber { get; set; }

    public decimal AmountReceived { get; set; }

    public string? Narration { get; set; }

    public string? PreparedBy { get; set; }

    public string? CheckedBy { get; set; }

    public DateTimeOffset Date { get; set; }

    public string? ReceivedBy { get; set; }

    public string? ContactNumberOfReceiver { get; set; }

    public int PaymentVoucherNumber { get; set; }
}
