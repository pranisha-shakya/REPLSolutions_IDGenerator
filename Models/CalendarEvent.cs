using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class CalendarEvent
{
    public int Id { get; set; }

    public int AcademicCalendarId { get; set; }

    public string Title { get; set; } = null!;

    public DateTimeOffset EffectiveFrom { get; set; }

    public DateTimeOffset EffectiveTo { get; set; }

    public bool? IsInternal { get; set; }

    public int? StudentId { get; set; }

    public int EventType { get; set; }

    public string? EventTypeText { get; set; }

    public virtual AcademicCalendar AcademicCalendar { get; set; } = null!;

    public virtual Student? Student { get; set; }
}
