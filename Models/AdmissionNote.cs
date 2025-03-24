using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class AdmissionNote
{
    public int Id { get; set; }

    public int AdmissionId { get; set; }

    public string Note { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTimeOffset CreatedOn { get; set; }

    public virtual Admission Admission { get; set; } = null!;
}
