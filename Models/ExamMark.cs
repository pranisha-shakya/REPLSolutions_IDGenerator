using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class ExamMark
{
    public int Id { get; set; }

    public float Theory { get; set; }

    public float Mcq { get; set; }

    public float Practical { get; set; }

    public float Total { get; set; }

    public string? Grade { get; set; }

    public int? CourseId { get; set; }

    public int? SessionId { get; set; }

    public int? StudentClassId { get; set; }

    public int? AdmissionId { get; set; }

    public virtual Admission? Admission { get; set; }

    public virtual Course? Course { get; set; }

    public virtual Intake? Session { get; set; }

    public virtual Classroom? StudentClass { get; set; }
}
