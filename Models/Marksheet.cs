using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Marksheet
{
    public int Id { get; set; }

    public int? AdmissionId { get; set; }

    public string? Remarks { get; set; }

    public int SchoolDays { get; set; }

    public int AttendanceDays { get; set; }

    public bool IsVisibleToParent { get; set; }

    public int ClassExamId { get; set; }

    public int Rank { get; set; }

    public int Status { get; set; }

    public Guid? BatchId { get; set; }

    public string? BatchName { get; set; }

    public int ClassRank { get; set; }

    public virtual Admission? Admission { get; set; }

    public virtual ClassExam ClassExam { get; set; } = null!;

    public virtual ICollection<MarksheetAssessment> MarksheetAssessments { get; set; } = new List<MarksheetAssessment>();
}
