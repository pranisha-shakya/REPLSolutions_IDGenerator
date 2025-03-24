using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class EmployeeEducation
{
    public int Id { get; set; }

    public int EducationLevelId { get; set; }

    public int? ExamTitleId { get; set; }

    public string Major { get; set; } = null!;

    public string InstituteName { get; set; } = null!;

    public int ResultType { get; set; }

    public float Cgpa { get; set; }

    public int Scale { get; set; }

    public float Marks { get; set; }

    public string PassingYear { get; set; } = null!;

    public int Duration { get; set; }

    public string? Achievement { get; set; }

    public int EmployeeId { get; set; }

    public virtual EducationLevel EducationLevel { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual ExamTitle? ExamTitle { get; set; }
}
