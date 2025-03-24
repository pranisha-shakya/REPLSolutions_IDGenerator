using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class AcademicCalendar
{
    public int Id { get; set; }

    public string Year { get; set; } = null!;

    public DateTimeOffset StartDate { get; set; }

    public DateTimeOffset EndDate { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<AcademicCalendarEvent> AcademicCalendarEvents { get; set; } = new List<AcademicCalendarEvent>();

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual ICollection<CalendarEvent> CalendarEvents { get; set; } = new List<CalendarEvent>();

    public virtual ICollection<Diary> Diaries { get; set; } = new List<Diary>();

    public virtual ICollection<Notice> Notices { get; set; } = new List<Notice>();

    public virtual ICollection<Term> Terms { get; set; } = new List<Term>();
}
