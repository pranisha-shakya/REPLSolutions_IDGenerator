using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Guardian
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? Email { get; set; }

    public string? Nid { get; set; }

    public string? Occupation { get; set; }

    public string? Address { get; set; }

    public int GuardianTypeId { get; set; }

    public Guid? UserId { get; set; }

    public virtual GuardianExtensionForIndium? GuardianExtensionForIndium { get; set; }

    public virtual GuardianType GuardianType { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
