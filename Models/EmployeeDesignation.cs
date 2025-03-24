using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class EmployeeDesignation
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
