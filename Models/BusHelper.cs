using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class BusHelper
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public virtual ICollection<BusZoneHelper> BusZoneHelpers { get; set; } = new List<BusZoneHelper>();

    public virtual Employee Employee { get; set; } = null!;
}
