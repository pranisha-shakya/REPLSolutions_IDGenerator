using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Assessment
{
    public int Id { get; set; }

    public int SubjectId { get; set; }

    public string Name { get; set; } = null!;

    public decimal FullMarks { get; set; }

    public decimal PassMarks { get; set; }

    public bool IsActive { get; set; }

    public string? Description { get; set; }

    public string DisplayGroup { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public string? SubjectCode { get; set; }

    public decimal CreditHour { get; set; }

    public string? Code { get; set; }

    public virtual ICollection<ClassExamAssessmentFullMark> ClassExamAssessmentFullMarks { get; set; } = new List<ClassExamAssessmentFullMark>();

    public virtual ICollection<MarksheetAssessment> MarksheetAssessments { get; set; } = new List<MarksheetAssessment>();

    public virtual Subject Subject { get; set; } = null!;
}
