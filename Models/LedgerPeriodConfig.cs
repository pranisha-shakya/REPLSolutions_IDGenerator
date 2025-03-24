using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class LedgerPeriodConfig
{
    public int Id { get; set; }

    public string? LedgerId { get; set; }

    public int AlertBefore { get; set; }

    public DateTimeOffset UpcomingTentativeClosingDate { get; set; }
}
