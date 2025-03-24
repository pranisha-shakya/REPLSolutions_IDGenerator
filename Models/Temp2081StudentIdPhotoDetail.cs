using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Temp2081StudentIdPhotoDetail
{
    public int Studentid { get; set; }

    public int Admissionid { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public int Gender { get; set; }

    public DateTimeOffset DateOfBirth { get; set; }

    public string? Studentnumber { get; set; }

    public byte[]? Image { get; set; }
}
