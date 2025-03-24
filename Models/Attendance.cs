using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Attendance
{
    public int Id { get; set; }

    public int AcademicCalanderId { get; set; }

    public int ClassroomId { get; set; }

    public int? AcademicCalendarEventId { get; set; }

    public DateTimeOffset AttendanceOnDate { get; set; }

    public string? Attendanceby { get; set; }

    public DateTimeOffset AttendanceOfDate { get; set; }

    public string? Note { get; set; }

    public virtual AcademicCalendar AcademicCalander { get; set; } = null!;

    public virtual AcademicCalendarEvent? AcademicCalendarEvent { get; set; }

    public virtual ICollection<AttendanceEntry> AttendanceEntries { get; set; } = new List<AttendanceEntry>();

    public virtual Classroom Classroom { get; set; } = null!;
}
