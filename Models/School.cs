using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class School
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string PhonePrimary { get; set; } = null!;

    public string? PhoneAlt { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public byte[]? Logo { get; set; }

    public string? ExternalReferenceId { get; set; }

    public string? Theme { get; set; }

    public bool DisplayRankinMarksheet { get; set; }

    public bool DisplayPercentinMarksheet { get; set; }

    public string? InvoiceHeaderImagePath { get; set; }

    public string? MarksheetHeaderImagePath { get; set; }

    public string? StudentIdCardTemplateImagePath { get; set; }

    public string? ReceiptHeaderImagePath { get; set; }

    public string? PrincipalSignatureImagePath { get; set; }

    public string? AffiliationNumber { get; set; }

    public string? SchoolCode { get; set; }

    public string? ImagePath { get; set; }
}
