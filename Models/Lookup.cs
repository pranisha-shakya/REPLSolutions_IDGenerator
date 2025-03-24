using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Lookup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }
}
