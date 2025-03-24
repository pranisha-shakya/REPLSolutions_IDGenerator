using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class SubjectTeacher
{
    public int Id { get; set; }

    public int TeacherId { get; set; }

    public int SubjectId { get; set; }

    public string? ClassroomIds { get; set; }

    public virtual Subject Subject { get; set; } = null!;

    public virtual Teacher Teacher { get; set; } = null!;
}
