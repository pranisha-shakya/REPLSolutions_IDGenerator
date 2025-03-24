using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class QueuedLineItem
{
    public int Id { get; set; }

    public int LineItemId { get; set; }

    public decimal Amount { get; set; }

    public DateTimeOffset StartDate { get; set; }

    public bool IsActive { get; set; }

    public DateTimeOffset EffectiveFrom { get; set; }

    public DateTimeOffset? EffectiveTo { get; set; }

    public string? Description { get; set; }

    public int RecurringType { get; set; }

    public string? RecurringTypeText { get; set; }

    public int LineItemType { get; set; }

    public string? LineItemTypeText { get; set; }

    public int QueueLevel { get; set; }

    public string? QueueLevelText { get; set; }

    public int QueueLevelValueId { get; set; }

    public string? QueueLevelValueDisplay { get; set; }

    public string? SubLineItem { get; set; }

    public virtual ICollection<InvoicedLineItem> InvoicedLineItems { get; set; } = new List<InvoicedLineItem>();

    public virtual LineItem LineItem { get; set; } = null!;
}
