using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Group
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public int? ParentGroupId { get; set; }

    public int Nature { get; set; }

    public virtual ICollection<GroupConfiguration> GroupConfigurations { get; set; } = new List<GroupConfiguration>();

    public virtual ICollection<Group> InverseParentGroup { get; set; } = new List<Group>();

    public virtual ICollection<Ledger> Ledgers { get; set; } = new List<Ledger>();

    public virtual Group? ParentGroup { get; set; }
}
