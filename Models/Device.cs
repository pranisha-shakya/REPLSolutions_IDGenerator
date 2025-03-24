using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Device
{
    public int Id { get; set; }

    public string? Identifier { get; set; }

    public virtual ICollection<DevicePlacement> DevicePlacements { get; set; } = new List<DevicePlacement>();
}
