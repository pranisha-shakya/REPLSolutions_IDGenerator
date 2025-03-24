using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class ClassExamAssessmentFullMark
{
    public int Id { get; set; }

    public int ClassExamId { get; set; }

    public decimal FullMarks { get; set; }

    public int AssessmentId { get; set; }

    public decimal CreditHours { get; set; }

    public virtual Assessment Assessment { get; set; } = null!;
}
