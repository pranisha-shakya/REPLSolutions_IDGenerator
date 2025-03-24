using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class BusZoneTrip
{
    public int Id { get; set; }

    public DateTimeOffset StartDate { get; set; }

    public DateTimeOffset? EndDate { get; set; }

    public int TripType { get; set; }

    public int BusZoneId { get; set; }

    public string? Path { get; set; }

    public virtual BusZone BusZone { get; set; } = null!;

    public virtual ICollection<BusZoneTripCheckpoint> BusZoneTripCheckpoints { get; set; } = new List<BusZoneTripCheckpoint>();
}
