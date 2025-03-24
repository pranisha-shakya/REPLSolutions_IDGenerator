using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class AcademicCalendarEventType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public bool Show { get; set; }
}
