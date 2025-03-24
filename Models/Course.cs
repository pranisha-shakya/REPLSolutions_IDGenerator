using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Course
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int Theory { get; set; }

    public int Mcq { get; set; }

    public int Practical { get; set; }

    public int Total { get; set; }

    public int ClassNameId { get; set; }

    public virtual Class ClassName { get; set; } = null!;

    public virtual ICollection<ExamMark> ExamMarks { get; set; } = new List<ExamMark>();
}
