using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Student
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

    public Guid Identifier { get; set; }

    public string? PlaceOfBirth { get; set; }

    public DateTimeOffset? DateOfFirstAdmission { get; set; }

    public string? ContactNumber { get; set; }

    public virtual ICollection<Admission> Admissions { get; set; } = new List<Admission>();

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    public virtual ICollection<AttendanceEntry> AttendanceEntries { get; set; } = new List<AttendanceEntry>();

    public virtual ICollection<CalendarEvent> CalendarEvents { get; set; } = new List<CalendarEvent>();

    public virtual ICollection<Guardian> Guardians { get; set; } = new List<Guardian>();

    public virtual ICollection<StudentCard> StudentCards { get; set; } = new List<StudentCard>();

    public virtual ICollection<StudentDocument> StudentDocuments { get; set; } = new List<StudentDocument>();

    public virtual StudentExtensionForIndium? StudentExtensionForIndium { get; set; }
}
