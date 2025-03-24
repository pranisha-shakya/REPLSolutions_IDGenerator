using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class TransferCertificate
{
    public int Id { get; set; }

    public string? Number { get; set; }

    public int CertificateVersion { get; set; }

    public int AdmissionId { get; set; }

    public string? Details { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public virtual Admission Admission { get; set; } = null!;
}
