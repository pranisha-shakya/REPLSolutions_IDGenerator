using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class JobInformation
{
    public int Id { get; set; }

    public int DesignationId { get; set; }

    public DateTime Doj { get; set; }

    public decimal Salary { get; set; }

    public int TotalLeave { get; set; }

    public byte[]? Appointment { get; set; }

    public string? AppointmentExt { get; set; }

    public int EmployeeId { get; set; }

    public virtual Designation Designation { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
