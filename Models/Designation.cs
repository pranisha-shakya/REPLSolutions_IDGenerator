using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Designation
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<JobInformation> JobInformations { get; set; } = new List<JobInformation>();
}
