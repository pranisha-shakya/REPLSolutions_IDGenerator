using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class StudentCard
{
    public int Id { get; set; }

    public string Identifier { get; set; } = null!;

    public int StudentId { get; set; }

    public DateTimeOffset AddedOn { get; set; }

    public string AddedBy { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
