using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class DevicePlacement
{
    public int Id { get; set; }

    public int DeviceId { get; set; }

    public int PlacementId { get; set; }

    public string? Stand { get; set; }

    public bool IsActive { get; set; }

    public DateTimeOffset From { get; set; }

    public DateTimeOffset? To { get; set; }

    public virtual ICollection<BusZoneDevicePlacement> BusZoneDevicePlacements { get; set; } = new List<BusZoneDevicePlacement>();

    public virtual Device Device { get; set; } = null!;

    public virtual Placement Placement { get; set; } = null!;
}
