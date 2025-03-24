using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class BusZone
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? Description { get; set; }

    public decimal Amount { get; set; }

    public string? DriverName { get; set; }

    public string? DriverMobileNumber { get; set; }

    public string? VehicleNumber { get; set; }

    public virtual ICollection<BusZoneCheckPoint> BusZoneCheckPoints { get; set; } = new List<BusZoneCheckPoint>();

    public virtual ICollection<BusZoneDevicePlacement> BusZoneDevicePlacements { get; set; } = new List<BusZoneDevicePlacement>();

    public virtual ICollection<BusZoneHelper> BusZoneHelpers { get; set; } = new List<BusZoneHelper>();

    public virtual ICollection<BusZoneTrip> BusZoneTrips { get; set; } = new List<BusZoneTrip>();
}
