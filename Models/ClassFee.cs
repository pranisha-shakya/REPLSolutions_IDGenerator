using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class ClassFee
{
    public int Id { get; set; }

    public decimal Fee { get; set; }

    public int ClassId { get; set; }

    public virtual Class Class { get; set; } = null!;
}
