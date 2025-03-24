using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class DefaultSetting
{
    public int Id { get; set; }

    public decimal Vat { get; set; }

    public decimal Smsbalance { get; set; }

    public bool Smsstatus { get; set; }

    public DateTime From { get; set; }

    public DateTime To { get; set; }

    public string? Language { get; set; }
}
