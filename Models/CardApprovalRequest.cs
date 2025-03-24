using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class CardApprovalRequest
{
    public int Id { get; set; }

    public string CardIdentifier { get; set; } = null!;

    public DateTimeOffset RequestedOn { get; set; }

    public string RequestedBy { get; set; } = null!;

    public DateTimeOffset? ApprovedOn { get; set; }

    public string? ApprovedBy { get; set; }
}
