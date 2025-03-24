using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class BusZoneHelper
{
    public int Id { get; set; }

    public int BusZoneId { get; set; }

    public int BusHelperId { get; set; }

    public virtual BusHelper BusHelper { get; set; } = null!;

    public virtual BusZone BusZone { get; set; } = null!;
}
