using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class StudentsBkpBfrImgDel13may24
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public int Gender { get; set; }

    public DateTimeOffset DateOfBirth { get; set; }

    public string? Email { get; set; }

    public string? Street { get; set; }

    public string? PostcodeOrWard { get; set; }

    public string? SuburbOrCity { get; set; }

    public string? StateOrProvince { get; set; }

    public string? PermanentAddress { get; set; }

    public byte[]? Image { get; set; }

    public string? DoctorName { get; set; }

    public string? DoctorContactNumber { get; set; }

    public int? BloodGroup { get; set; }

    public string? MedicalDetails { get; set; }

    public string? Comments { get; set; }

    public bool IsMigrated { get; set; }

    public string? AuthorizedGuardianUserId { get; set; }

    public int? Religion { get; set; }

    public string? Interests { get; set; }

    public string? SiblingStudentIds { get; set; }

    public string? RelativeEmployeeIds { get; set; }

    public string? ImagePath { get; set; }
}
