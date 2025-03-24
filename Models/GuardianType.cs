using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class GuardianType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Guardian> Guardians { get; set; } = new List<Guardian>();
}
