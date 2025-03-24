using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class AcademicCalendarEvent
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTimeOffset StartDate { get; set; }

    public DateTimeOffset EndDate { get; set; }

    public int AcademicCalendarId { get; set; }

    public int EventLevel { get; set; }

    public string? EventLevelText { get; set; }

    public string? EventLevelValueDisplay { get; set; }

    public int EventValueId { get; set; }

    public string? EventTypeCode { get; set; }

    public string? EventTypeText { get; set; }

    public string? EventTypeDescription { get; set; }

    public bool IsActive { get; set; }

    public bool IsInternal { get; set; }

    public bool AutoAttendance { get; set; }

    public bool Sunday { get; set; }

    public bool Monday { get; set; }

    public bool Tuesday { get; set; }

    public bool Wednesday { get; set; }

    public bool Thursday { get; set; }

    public bool Friday { get; set; }

    public bool Saturday { get; set; }

    public string? Note { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public virtual AcademicCalendar AcademicCalendar { get; set; } = null!;

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
}
