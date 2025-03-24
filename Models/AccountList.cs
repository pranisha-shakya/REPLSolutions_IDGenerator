using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class AccountList
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Date { get; set; }

    public decimal OpeningBalance { get; set; }

    public decimal CurrentBalance { get; set; }

    public int AccountGroupId { get; set; }

    public virtual AccountGroup AccountGroup { get; set; } = null!;
}
