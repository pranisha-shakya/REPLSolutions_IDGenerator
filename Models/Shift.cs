using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Shift
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Classroom> Classrooms { get; set; } = new List<Classroom>();
}
