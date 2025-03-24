using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class LineItem
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? Description { get; set; }

    public int DisplayOrder { get; set; }

    public int Category { get; set; }

    public string? CategoryText { get; set; }

    public int PaymentPriority { get; set; }

    public virtual ICollection<QueuedLineItem> QueuedLineItems { get; set; } = new List<QueuedLineItem>();
}
