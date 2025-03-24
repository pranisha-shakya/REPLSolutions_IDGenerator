using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class DiscountType
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? Description { get; set; }
}
