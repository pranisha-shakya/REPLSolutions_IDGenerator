using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Admission
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public string? StudentNumber { get; set; }

    public string? RollNumber { get; set; }

    public int IntakeId { get; set; }

    public int ClassId { get; set; }

    public int? ClassroomId { get; set; }

    public string? Year { get; set; }

    public int? ScholarType { get; set; }

    public string? BusZoneCode { get; set; }

    public string? BusPickupLocation { get; set; }

    public string? BusDropOffLocation { get; set; }

    public int Status { get; set; }

    public string? FoodServiceTypeCode { get; set; }

    public string? DiscountTypeCode { get; set; }

    public string? Comments { get; set; }

    public decimal? DiscountAmount { get; set; }

    public DateTimeOffset? AdmissionDate { get; set; }

    public DateTimeOffset CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTimeOffset? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTimeOffset? TerminatedDate { get; set; }

    public string? TerminatedBy { get; set; }

    public string? TerminationReason { get; set; }

    public string? StudyMedium { get; set; }

    public string? RegistrationNumber { get; set; }

    public string? SymbolNumber { get; set; }

    public string? BusZoneCheckpointNotifications { get; set; }

    public virtual ICollection<AdmissionNote> AdmissionNotes { get; set; } = new List<AdmissionNote>();

    public virtual Class Class { get; set; } = null!;

    public virtual Classroom? Classroom { get; set; }

    public virtual ICollection<ExamMark> ExamMarks { get; set; } = new List<ExamMark>();

    public virtual ICollection<FlatReceipt> FlatReceipts { get; set; } = new List<FlatReceipt>();

    public virtual Intake Intake { get; set; } = null!;

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<Marksheet> Marksheets { get; set; } = new List<Marksheet>();

    public virtual Student Student { get; set; } = null!;

    public virtual ICollection<StudentSubject> StudentSubjects { get; set; } = new List<StudentSubject>();

    public virtual ICollection<TransferCertificate> TransferCertificates { get; set; } = new List<TransferCertificate>();
}
