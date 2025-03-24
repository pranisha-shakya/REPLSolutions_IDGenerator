using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class AuditLog
{
    public int Id { get; set; }

    public string TableName { get; set; } = null!;

    public string? PrimaryKey { get; set; }

    public string? OriginalValues { get; set; }

    public string? CurrentValues { get; set; }

    public string Action { get; set; } = null!;

    public string ActionedBy { get; set; } = null!;

    public DateTimeOffset ActionedDate { get; set; }
}
