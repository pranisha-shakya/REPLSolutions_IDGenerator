using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Classroom
{
    public int Id { get; set; }

    public int ClassId { get; set; }

    public int SectionId { get; set; }

    public int ShiftId { get; set; }

    public string? LiveClassUrl { get; set; }

    public int? TeacherId { get; set; }

    public string? TeacherIds { get; set; }

    public virtual ICollection<Admission> Admissions { get; set; } = new List<Admission>();

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual Class Class { get; set; } = null!;

    public virtual ICollection<ExamMark> ExamMarks { get; set; } = new List<ExamMark>();

    public virtual Section Section { get; set; } = null!;

    public virtual Shift Shift { get; set; } = null!;

    public virtual Teacher? Teacher { get; set; }
}
