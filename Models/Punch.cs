using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Punch
{
    public int Id { get; set; }

    public string? DeviceIdentifier { get; set; }

    public string? CardIdentifier { get; set; }

    public DateTimeOffset PunchTime { get; set; }

    public string? LocationCordinates { get; set; }

    public DateTimeOffset? ProcessedOn { get; set; }
}
