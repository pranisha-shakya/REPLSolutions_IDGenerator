using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Resource
{
    public int Id { get; set; }

    public string? Url { get; set; }

    public string? Tags { get; set; }

    public bool IsActive { get; set; }

    public DateTimeOffset DateOfUpoload { get; set; }

    public int MinimumAgeOfViewer { get; set; }

    public int ResourceType { get; set; }

    public int ContentType { get; set; }

    public string? UploadedBy { get; set; }
}
