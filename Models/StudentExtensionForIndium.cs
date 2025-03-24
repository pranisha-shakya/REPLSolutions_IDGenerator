using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class StudentExtensionForIndium
{
    public int Id { get; set; }

    public string? PanCardNumber { get; set; }

    public bool? IsBplCardHolder { get; set; }

    public int? Varg { get; set; }

    public string? RationCardNumber { get; set; }

    public string? Caste { get; set; }

    public string? AadharCardNumber { get; set; }

    public string? SssmId { get; set; }

    public string? BankName { get; set; }

    public string? BankAccountNumber { get; set; }

    public string? Ifsc { get; set; }

    public string? ScholarNumber { get; set; }

    public string? Pen { get; set; }

    public string? FamilySssmId { get; set; }

    public virtual Student IdNavigation { get; set; } = null!;
}
