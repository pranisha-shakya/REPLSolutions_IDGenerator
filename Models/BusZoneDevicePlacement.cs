using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class BusZoneDevicePlacement
{
    public int Id { get; set; }

    public int BusZoneId { get; set; }

    public int DevicePlacementId { get; set; }

    public virtual BusZone BusZone { get; set; } = null!;

    public virtual DevicePlacement DevicePlacement { get; set; } = null!;
}
