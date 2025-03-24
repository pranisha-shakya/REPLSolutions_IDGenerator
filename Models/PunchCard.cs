using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class PunchCard
{
    public int Id { get; set; }

    public int PlacementId { get; set; }

    public string? CardIdentifier { get; set; }

    public DateTimeOffset PunchOn { get; set; }

    public int PunchOnDevicePlacementId { get; set; }

    public string? PunchOnReference { get; set; }

    public DateTimeOffset? PunchOff { get; set; }

    public string? PunchOffReference { get; set; }

    public int? PunchOffDevicePlacementId { get; set; }

    public string? DiscardedPunches { get; set; }

    public string? ProcessedBy { get; set; }

    public virtual Placement Placement { get; set; } = null!;
}
