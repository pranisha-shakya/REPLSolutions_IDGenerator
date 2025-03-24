using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class ClassExam
{
    public int Id { get; set; }

    public int ExamId { get; set; }

    public int ClassId { get; set; }

    public bool IsMarksheetvisibleToParent { get; set; }

    public int? ContributionExamId { get; set; }

    public decimal ContributionPercentage { get; set; }

    public DateTimeOffset DistributionDate { get; set; }

    public int TermId { get; set; }

    public bool IsActive { get; set; }

    public virtual Class Class { get; set; } = null!;

    public virtual ClassExam? ContributionExam { get; set; }

    public virtual Exam Exam { get; set; } = null!;

    public virtual ICollection<ClassExam> InverseContributionExam { get; set; } = new List<ClassExam>();

    public virtual ICollection<Marksheet> Marksheets { get; set; } = new List<Marksheet>();

    public virtual Term Term { get; set; } = null!;
}
