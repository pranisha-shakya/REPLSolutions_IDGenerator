using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class EmploymentHistory
{
    public int Id { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? CompanyLocation { get; set; }

    public string Designation { get; set; } = null!;

    public DateTime From { get; set; }

    public DateTime To { get; set; }

    public int EmployeeId { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
