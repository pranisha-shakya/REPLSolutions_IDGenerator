using System;
using System.Collections.Generic;

namespace REPLSolutions_IDGenerator.Models;

public partial class Notice
{
    public int Id { get; set; }

    public string Subject { get; set; } = null!;

    public int NoticeLevel { get; set; }

    public int NoticeType { get; set; }

    public string? Body { get; set; }

    public byte[]? Image { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public DateTimeOffset ExpiryDate { get; set; }

    public string? CreatedBy { get; set; }

    public int AcademicCalendarId { get; set; }

    public int NoticeLevelItemId { get; set; }

    public string? NoticeLevelText { get; set; }

    public string? NoticeLevelValueDisplay { get; set; }

    public bool IsListing { get; set; }

    public string? NoticeTypeText { get; set; }

    public bool IsNoticeViewed { get; set; }

    public DateTimeOffset? NoticeViewedAt { get; set; }

    public string? Path { get; set; }

    public virtual AcademicCalendar AcademicCalendar { get; set; } = null!;
}
