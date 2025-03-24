using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class PromptAcknowledgment
{
    public int Id { get; set; }

    public int PromptAcknowledgementFor { get; set; }

    public string? PromptUrl { get; set; }

    public string? AcknowledgementForValueId { get; set; }

    public string? PromptAcknowledgementForText { get; set; }

    public string? AcknowledgedBy { get; set; }

    public DateTimeOffset AcknowledgedOn { get; set; }
}
