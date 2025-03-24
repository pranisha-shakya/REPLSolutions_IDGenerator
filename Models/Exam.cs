using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Exam
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? Description { get; set; }

    public bool IsContributed { get; set; }

    public virtual ICollection<ClassExam> ClassExams { get; set; } = new List<ClassExam>();
}
