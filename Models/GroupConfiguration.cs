using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class GroupConfiguration
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTimeOffset ValidFrom { get; set; }

    public DateTimeOffset ValidTo { get; set; }

    public int GroupId { get; set; }

    public virtual Group Group { get; set; } = null!;
}
