using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Term
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTimeOffset StartDate { get; set; }

    public DateTimeOffset EndDate { get; set; }

    public int AcademiccalendarId { get; set; }

    public virtual AcademicCalendar Academiccalendar { get; set; } = null!;

    public virtual ICollection<ClassExam> ClassExams { get; set; } = new List<ClassExam>();
}
