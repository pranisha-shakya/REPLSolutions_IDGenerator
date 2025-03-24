using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Intake
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Admission> Admissions { get; set; } = new List<Admission>();

    public virtual ICollection<ExamMark> ExamMarks { get; set; } = new List<ExamMark>();
}
