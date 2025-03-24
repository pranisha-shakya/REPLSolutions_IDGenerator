using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class EducationLevel
{
    public int Id { get; set; }

    public string EducationLevelName { get; set; } = null!;

    public virtual ICollection<EmployeeEducation> EmployeeEducations { get; set; } = new List<EmployeeEducation>();

    public virtual ICollection<ExamTitle> ExamTitles { get; set; } = new List<ExamTitle>();
}
