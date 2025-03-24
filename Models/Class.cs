using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Class
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool GenerateMarksheetView { get; set; }

    public bool CompulsorySubject { get; set; }

    public bool PersonalAssessmentSubject { get; set; }

    public bool GenerateDetailMarksheet { get; set; }

    public bool DetailCompulsorySubject { get; set; }

    public bool DetailPersonalAssessmentSubject { get; set; }

    public int NumberOfSubject { get; set; }

    public virtual ICollection<Admission> Admissions { get; set; } = new List<Admission>();

    public virtual ICollection<ClassExam> ClassExams { get; set; } = new List<ClassExam>();

    public virtual ICollection<ClassFee> ClassFees { get; set; } = new List<ClassFee>();

    public virtual ICollection<Classroom> Classrooms { get; set; } = new List<Classroom>();

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
