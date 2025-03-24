using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Placement
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int ThresholdMinimum { get; set; }

    public int ThresholdMaximum { get; set; }

    public bool SendNotification { get; set; }

    public string? PlacementType { get; set; }

    public virtual ICollection<DevicePlacement> DevicePlacements { get; set; } = new List<DevicePlacement>();

    public virtual ICollection<PunchCard> PunchCards { get; set; } = new List<PunchCard>();
}
