using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class ReferenceSubject
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public string Code { get; set; } = null!;

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
