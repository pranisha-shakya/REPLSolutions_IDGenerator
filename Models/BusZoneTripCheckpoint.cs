using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class BusZoneTripCheckpoint
{
    public int Id { get; set; }

    public int BusZoneTripId { get; set; }

    public int BusZoneCheckpointId { get; set; }

    public DateTimeOffset ArrivedAt { get; set; }

    public DateTimeOffset? ArrivedAtCheckpointOn { get; set; }

    public DateTimeOffset? DeparturedFromCheckpointOn { get; set; }

    public DateTimeOffset? DeparturedAt { get; set; }

    public virtual BusZoneCheckPoint BusZoneCheckpoint { get; set; } = null!;

    public virtual BusZoneTrip BusZoneTrip { get; set; } = null!;
}
