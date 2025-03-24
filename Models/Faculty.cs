using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Faculty
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
}
