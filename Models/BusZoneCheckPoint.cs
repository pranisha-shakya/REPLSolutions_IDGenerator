using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class BusZoneCheckPoint
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public int Order { get; set; }

    public int BusZoneId { get; set; }

    public virtual BusZone BusZone { get; set; } = null!;

    public virtual ICollection<BusZoneTripCheckpoint> BusZoneTripCheckpoints { get; set; } = new List<BusZoneTripCheckpoint>();
}
