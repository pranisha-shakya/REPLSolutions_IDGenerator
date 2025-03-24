using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class GuardianExtensionForIndium
{
    public int Id { get; set; }

    public string? AadharCardNumber { get; set; }

    public string? SssmId { get; set; }

    public virtual Guardian IdNavigation { get; set; } = null!;
}
