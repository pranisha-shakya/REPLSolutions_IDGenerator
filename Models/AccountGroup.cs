using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class AccountGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AccountList> AccountLists { get; set; } = new List<AccountList>();
}
