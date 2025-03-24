using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Teacher
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public string? SubjectCodes { get; set; }

    public virtual ICollection<Classroom> Classrooms { get; set; } = new List<Classroom>();

    public virtual Employee Employee { get; set; } = null!;

    public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; } = new List<SubjectTeacher>();
}
