using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class ExamTitle
{
    public int Id { get; set; }

    public string TitleName { get; set; } = null!;

    public int EducationLevelId { get; set; }

    public virtual EducationLevel EducationLevel { get; set; } = null!;

    public virtual ICollection<EmployeeEducation> EmployeeEducations { get; set; } = new List<EmployeeEducation>();
}
