using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class StudentSubject
{
    public int Id { get; set; }

    public int? AdmissionId { get; set; }

    public int? SubjectId { get; set; }

    public virtual Admission? Admission { get; set; }

    public virtual Subject? Subject { get; set; }
}
