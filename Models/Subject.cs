using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Subject
{
    public int Id { get; set; }

    public int ClassId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? Description { get; set; }

    public int DisplayOrder { get; set; }

    public int? ReferenceSubjectId { get; set; }

    public bool IsEca { get; set; }

    public bool IsCompulsory { get; set; }

    public string? ReferenceSubjectCode { get; set; }

    public virtual ICollection<Assessment> Assessments { get; set; } = new List<Assessment>();

    public virtual Class Class { get; set; } = null!;

    public virtual ReferenceSubject? ReferenceSubject { get; set; }

    public virtual ICollection<StudentSubject> StudentSubjects { get; set; } = new List<StudentSubject>();

    public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; } = new List<SubjectTeacher>();
}
