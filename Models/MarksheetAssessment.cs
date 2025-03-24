using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class MarksheetAssessment
{
    public int Id { get; set; }

    public decimal ObtainedMarks { get; set; }

    public string? Remark { get; set; }

    public int MarksheetId { get; set; }

    public int AssessmentId { get; set; }

    public bool IsAbsent { get; set; }

    public virtual Assessment Assessment { get; set; } = null!;

    public virtual Marksheet Marksheet { get; set; } = null!;
}
