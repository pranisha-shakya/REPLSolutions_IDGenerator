using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class StudentDocument
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Path { get; set; }

    public int StudentId { get; set; }

    public virtual Student Student { get; set; } = null!;
}
