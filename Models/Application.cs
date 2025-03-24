using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Application
{
    public int Id { get; set; }

    public DateTimeOffset ApplicationDate { get; set; }

    public string? PreviousSchoolName { get; set; }

    public string? PreviousSchoolAddress { get; set; }

    public byte[]? PreviousSchoolDocument { get; set; }

    public int FacultyId { get; set; }

    public int StudentId { get; set; }

    public string? PreviousSchoolNotes { get; set; }

    public virtual Faculty Faculty { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
