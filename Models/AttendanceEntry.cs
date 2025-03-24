using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class AttendanceEntry
{
    public int Id { get; set; }

    public int AttendanceId { get; set; }

    public int StudentId { get; set; }

    public bool IsPresent { get; set; }

    public bool IsLeave { get; set; }

    public virtual Attendance Attendance { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
