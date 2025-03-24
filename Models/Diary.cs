using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Diary
{
    public int Id { get; set; }

    public string Subject { get; set; } = null!;

    public int ContentLevel { get; set; }

    public int ContentType { get; set; }

    public string? Body { get; set; }

    public string? Path { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public DateTimeOffset ExpiryDate { get; set; }

    public string? CreatedBy { get; set; }

    public int AcademicCalendarId { get; set; }

    public int ContentLevelItemId { get; set; }

    public string? ContentLevelText { get; set; }

    public string? ContentLevelValueDisplay { get; set; }

    public bool IsListing { get; set; }

    public string? ContentTypeText { get; set; }

    public bool IsContentViewed { get; set; }

    public DateTimeOffset? ContentViewedAt { get; set; }

    public virtual AcademicCalendar AcademicCalendar { get; set; } = null!;
}
