using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public int Gender { get; set; }

    public DateTime Dob { get; set; }

    public string? MaritalStatus { get; set; }

    public int Religion { get; set; }

    public string? Nationality { get; set; }

    public string? Nid { get; set; }

    public string? PresentAddress { get; set; }

    public string? PermanentAddress { get; set; }

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public byte[]? Image { get; set; }

    public string? UserName { get; set; }

    public int? EmployeeDesignationId { get; set; }

    public string? ImagePath { get; set; }

    public Guid Identifier { get; set; }

    public Guid LoginGuid { get; set; }

    public virtual ICollection<BusHelper> BusHelpers { get; set; } = new List<BusHelper>();

    public virtual EmployeeDesignation? EmployeeDesignation { get; set; }

    public virtual ICollection<EmployeeEducation> EmployeeEducations { get; set; } = new List<EmployeeEducation>();

    public virtual ICollection<EmploymentHistory> EmploymentHistories { get; set; } = new List<EmploymentHistory>();

    public virtual ICollection<JobInformation> JobInformations { get; set; } = new List<JobInformation>();

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
