using Microsoft.EntityFrameworkCore;

namespace REPLSolutions_IDGenerator.Models;

public partial class ReplsolutionsDemoContext : DbContext
{
    public ReplsolutionsDemoContext()
    {
    }

    public ReplsolutionsDemoContext(DbContextOptions<ReplsolutionsDemoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AcademicCalendar> AcademicCalendars { get; set; }

    public virtual DbSet<AcademicCalendarEvent> AcademicCalendarEvents { get; set; }

    public virtual DbSet<AcademicCalendarEventType> AcademicCalendarEventTypes { get; set; }

    public virtual DbSet<AccountGroup> AccountGroups { get; set; }

    public virtual DbSet<AccountList> AccountLists { get; set; }

    public virtual DbSet<AccountingLookup> AccountingLookups { get; set; }

    public virtual DbSet<Adjustment> Adjustments { get; set; }

    public virtual DbSet<Admission> Admissions { get; set; }

    public virtual DbSet<AdmissionNote> AdmissionNotes { get; set; }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<Assessment> Assessments { get; set; }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<AttendanceEntry> AttendanceEntries { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<BusHelper> BusHelpers { get; set; }

    public virtual DbSet<BusZone> BusZones { get; set; }

    public virtual DbSet<BusZoneCheckPoint> BusZoneCheckPoints { get; set; }

    public virtual DbSet<BusZoneDevicePlacement> BusZoneDevicePlacements { get; set; }

    public virtual DbSet<BusZoneHelper> BusZoneHelpers { get; set; }

    public virtual DbSet<BusZoneTrip> BusZoneTrips { get; set; }

    public virtual DbSet<BusZoneTripCheckpoint> BusZoneTripCheckpoints { get; set; }

    public virtual DbSet<CalendarEvent> CalendarEvents { get; set; }

    public virtual DbSet<CardApprovalRequest> CardApprovalRequests { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<ClassExam> ClassExams { get; set; }

    public virtual DbSet<ClassExamAssessmentFullMark> ClassExamAssessmentFullMarks { get; set; }

    public virtual DbSet<ClassFee> ClassFees { get; set; }

    public virtual DbSet<Classroom> Classrooms { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<DefaultSetting> DefaultSettings { get; set; }

    public virtual DbSet<DeletedReceipt> DeletedReceipts { get; set; }

    public virtual DbSet<Designation> Designations { get; set; }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<DevicePlacement> DevicePlacements { get; set; }

    public virtual DbSet<Diary> Diaries { get; set; }

    public virtual DbSet<DiscountType> DiscountTypes { get; set; }

    public virtual DbSet<EducationLevel> EducationLevels { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeDesignation> EmployeeDesignations { get; set; }

    public virtual DbSet<EmployeeEducation> EmployeeEducations { get; set; }

    public virtual DbSet<EmploymentHistory> EmploymentHistories { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<ExamMark> ExamMarks { get; set; }

    public virtual DbSet<ExamTitle> ExamTitles { get; set; }

    public virtual DbSet<Faculty> Faculties { get; set; }

    public virtual DbSet<FlatPayment> FlatPayments { get; set; }

    public virtual DbSet<FlatReceipt> FlatReceipts { get; set; }

    public virtual DbSet<FoodServiceType> FoodServiceTypes { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupConfiguration> GroupConfigurations { get; set; }

    public virtual DbSet<Guardian> Guardians { get; set; }

    public virtual DbSet<GuardianExtensionForIndium> GuardianExtensionForIndia { get; set; }

    public virtual DbSet<GuardianType> GuardianTypes { get; set; }

    public virtual DbSet<Intake> Intakes { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoicedLineItem> InvoicedLineItems { get; set; }

    public virtual DbSet<InvoicedLineItemPayment> InvoicedLineItemPayments { get; set; }

    public virtual DbSet<JobInformation> JobInformations { get; set; }

    public virtual DbSet<Ledger> Ledgers { get; set; }

    public virtual DbSet<LedgerPeriod> LedgerPeriods { get; set; }

    public virtual DbSet<LedgerPeriodConfig> LedgerPeriodConfigs { get; set; }

    public virtual DbSet<LedgerStatement> LedgerStatements { get; set; }

    public virtual DbSet<LineItem> LineItems { get; set; }

    public virtual DbSet<Lookup> Lookups { get; set; }

    public virtual DbSet<Marksheet> Marksheets { get; set; }

    public virtual DbSet<MarksheetAssessment> MarksheetAssessments { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<Notice> Notices { get; set; }

    public virtual DbSet<Placement> Placements { get; set; }

    public virtual DbSet<PromptAcknowledgment> PromptAcknowledgments { get; set; }

    public virtual DbSet<Punch> Punches { get; set; }

    public virtual DbSet<PunchCard> PunchCards { get; set; }

    public virtual DbSet<QueuedLineItem> QueuedLineItems { get; set; }

    public virtual DbSet<Receipt> Receipts { get; set; }

    public virtual DbSet<ReferenceSubject> ReferenceSubjects { get; set; }

    public virtual DbSet<Resource> Resources { get; set; }

    public virtual DbSet<School> Schools { get; set; }

    public virtual DbSet<Section> Sections { get; set; }

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentCard> StudentCards { get; set; }

    public virtual DbSet<StudentDocument> StudentDocuments { get; set; }

    public virtual DbSet<StudentExtensionForIndium> StudentExtensionForIndia { get; set; }

    public virtual DbSet<StudentSubject> StudentSubjects { get; set; }

    public virtual DbSet<StudentsBkpBfrImgDel13may24> StudentsBkpBfrImgDel13may24s { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<SubjectTeacher> SubjectTeachers { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<Temp2081StudentIdPhotoDetail> Temp2081StudentIdPhotoDetails { get; set; }

    public virtual DbSet<Term> Terms { get; set; }

    public virtual DbSet<TransferCertificate> TransferCertificates { get; set; }

    public virtual DbSet<VoucherEntry> VoucherEntries { get; set; }

    public virtual DbSet<VoucherEntryDetail> VoucherEntryDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcademicCalendar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AcademicCalendars");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Year).HasMaxLength(20);
        });

        modelBuilder.Entity<AcademicCalendarEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AcademicCalendarEvents");

            entity.HasIndex(e => e.AcademicCalendarId, "IX_AcademicCalendarId");

            entity.Property(e => e.Name).HasMaxLength(800);

            entity.HasOne(d => d.AcademicCalendar).WithMany(p => p.AcademicCalendarEvents)
                .HasForeignKey(d => d.AcademicCalendarId)
                .HasConstraintName("FK_dbo.AcademicCalendarEvents_dbo.AcademicCalendars_AcademicCalendarId");
        });

        modelBuilder.Entity<AcademicCalendarEventType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AcademicCalendarEventTypes");
        });

        modelBuilder.Entity<AccountGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AccountGroups");
        });

        modelBuilder.Entity<AccountList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AccountLists");

            entity.HasIndex(e => e.AccountGroupId, "IX_AccountGroupId");

            entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AccountGroup).WithMany(p => p.AccountLists)
                .HasForeignKey(d => d.AccountGroupId)
                .HasConstraintName("FK_dbo.AccountLists_dbo.AccountGroups_AccountGroupId");
        });

        modelBuilder.Entity<AccountingLookup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AccountingLookups");

            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Adjustment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Adjustments");

            entity.HasIndex(e => e.InvoiceId, "IX_InvoiceId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(500);

            entity.HasOne(d => d.Invoice).WithMany(p => p.Adjustments)
                .HasForeignKey(d => d.InvoiceId)
                .HasConstraintName("FK_dbo.Adjustments_dbo.Invoices_InvoiceId");
        });

        modelBuilder.Entity<Admission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Admissions");

            entity.HasIndex(e => e.ClassId, "IX_ClassId");

            entity.HasIndex(e => e.ClassroomId, "IX_ClassroomId");

            entity.HasIndex(e => e.IntakeId, "IX_IntakeId");

            entity.HasIndex(e => e.StudentId, "IX_StudentId");

            entity.Property(e => e.BusDropOffLocation).HasMaxLength(100);
            entity.Property(e => e.BusPickupLocation).HasMaxLength(100);
            entity.Property(e => e.BusZoneCheckpointNotifications).HasMaxLength(50);
            entity.Property(e => e.BusZoneCode).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountTypeCode).HasMaxLength(20);
            entity.Property(e => e.FoodServiceTypeCode).HasMaxLength(20);
            entity.Property(e => e.RegistrationNumber).HasMaxLength(100);
            entity.Property(e => e.RollNumber).HasMaxLength(100);
            entity.Property(e => e.StudentNumber).HasMaxLength(100);
            entity.Property(e => e.SymbolNumber).HasMaxLength(100);
            entity.Property(e => e.TerminatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Year).HasMaxLength(20);

            entity.HasOne(d => d.Class).WithMany(p => p.Admissions)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK_dbo.Admissions_dbo.Classes_ClassId");

            entity.HasOne(d => d.Classroom).WithMany(p => p.Admissions)
                .HasForeignKey(d => d.ClassroomId)
                .HasConstraintName("FK_dbo.Admissions_dbo.Classrooms_ClassroomId");

            entity.HasOne(d => d.Intake).WithMany(p => p.Admissions)
                .HasForeignKey(d => d.IntakeId)
                .HasConstraintName("FK_dbo.Admissions_dbo.Intakes_IntakeId");

            entity.HasOne(d => d.Student).WithMany(p => p.Admissions)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_dbo.Admissions_dbo.Students_StudentId");
        });

        modelBuilder.Entity<AdmissionNote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AdmissionNotes");

            entity.HasIndex(e => e.AdmissionId, "IX_AdmissionId");

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(500);

            entity.HasOne(d => d.Admission).WithMany(p => p.AdmissionNotes)
                .HasForeignKey(d => d.AdmissionId)
                .HasConstraintName("FK_dbo.AdmissionNotes_dbo.Admissions_AdmissionId");
        });

        modelBuilder.Entity<Application>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Applications");

            entity.HasIndex(e => e.FacultyId, "IX_FacultyId");

            entity.HasIndex(e => e.StudentId, "IX_StudentId");

            entity.Property(e => e.PreviousSchoolAddress).HasMaxLength(200);
            entity.Property(e => e.PreviousSchoolName).HasMaxLength(200);

            entity.HasOne(d => d.Faculty).WithMany(p => p.Applications)
                .HasForeignKey(d => d.FacultyId)
                .HasConstraintName("FK_dbo.Applications_dbo.Faculties_FacultyId");

            entity.HasOne(d => d.Student).WithMany(p => p.Applications)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_dbo.Applications_dbo.Students_StudentId");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetRoles");

            entity.HasIndex(e => e.Name, "RoleNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUsers");

            entity.HasIndex(e => e.UserName, "UserNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_RoleId");
                        j.HasIndex(new[] { "UserId" }, "IX_UserId");
                        j.IndexerProperty<string>("UserId").HasMaxLength(128);
                        j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUserClaims");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId }).HasName("PK_dbo.AspNetUserLogins");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<Assessment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Assessments");

            entity.HasIndex(e => e.SubjectId, "IX_SubjectId");

            entity.Property(e => e.Code).HasMaxLength(5);
            entity.Property(e => e.CreditHour).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DisplayGroup).HasMaxLength(50);
            entity.Property(e => e.FullMarks).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PassMarks).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SubjectCode).HasMaxLength(5);

            entity.HasOne(d => d.Subject).WithMany(p => p.Assessments)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_dbo.Assessments_dbo.Subjects_SubjectId");
        });

        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Attendances");

            entity.HasIndex(e => e.AcademicCalanderId, "IX_AcademicCalanderId");

            entity.HasIndex(e => e.AcademicCalendarEventId, "IX_AcademicCalendarEventId");

            entity.HasIndex(e => e.ClassroomId, "IX_ClassroomId");

            entity.HasOne(d => d.AcademicCalander).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.AcademicCalanderId)
                .HasConstraintName("FK_dbo.Attendances_dbo.AcademicCalendars_AcademicCalanderId");

            entity.HasOne(d => d.AcademicCalendarEvent).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.AcademicCalendarEventId)
                .HasConstraintName("FK_dbo.Attendances_dbo.AcademicCalendarEvents_AcademicCalendarEventId");

            entity.HasOne(d => d.Classroom).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.ClassroomId)
                .HasConstraintName("FK_dbo.Attendances_dbo.Classrooms_ClassroomId");
        });

        modelBuilder.Entity<AttendanceEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AttendanceEntries");

            entity.HasIndex(e => e.AttendanceId, "IX_AttendanceId");

            entity.HasIndex(e => e.StudentId, "IX_StudentId");

            entity.HasOne(d => d.Attendance).WithMany(p => p.AttendanceEntries)
                .HasForeignKey(d => d.AttendanceId)
                .HasConstraintName("FK_dbo.AttendanceEntries_dbo.Attendances_AttendanceId");

            entity.HasOne(d => d.Student).WithMany(p => p.AttendanceEntries)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_dbo.AttendanceEntries_dbo.Students_StudentId");
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AuditLogs");

            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.ActionedBy).HasMaxLength(100);
            entity.Property(e => e.PrimaryKey).HasMaxLength(100);
            entity.Property(e => e.TableName).HasMaxLength(100);
        });

        modelBuilder.Entity<BusHelper>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.BusHelpers");

            entity.HasIndex(e => e.EmployeeId, "IX_EmployeeId");

            entity.HasOne(d => d.Employee).WithMany(p => p.BusHelpers)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_dbo.BusHelpers_dbo.Employees_EmployeeId");
        });

        modelBuilder.Entity<BusZone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.BusZones");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.DriverMobileNumber).HasMaxLength(50);
            entity.Property(e => e.DriverName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.VehicleNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<BusZoneCheckPoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.BusZoneCheckPoints");

            entity.HasIndex(e => e.BusZoneId, "IX_BusZoneId");

            entity.HasOne(d => d.BusZone).WithMany(p => p.BusZoneCheckPoints)
                .HasForeignKey(d => d.BusZoneId)
                .HasConstraintName("FK_dbo.BusZoneCheckPoints_dbo.BusZones_BusZoneId");
        });

        modelBuilder.Entity<BusZoneDevicePlacement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.BusZoneDevicePlacements");

            entity.HasIndex(e => e.BusZoneId, "IX_BusZoneId");

            entity.HasIndex(e => e.DevicePlacementId, "IX_DevicePlacementId");

            entity.HasOne(d => d.BusZone).WithMany(p => p.BusZoneDevicePlacements)
                .HasForeignKey(d => d.BusZoneId)
                .HasConstraintName("FK_dbo.BusZoneDevicePlacements_dbo.BusZones_BusZoneId");

            entity.HasOne(d => d.DevicePlacement).WithMany(p => p.BusZoneDevicePlacements)
                .HasForeignKey(d => d.DevicePlacementId)
                .HasConstraintName("FK_dbo.BusZoneDevicePlacements_dbo.DevicePlacements_DevicePlacementId");
        });

        modelBuilder.Entity<BusZoneHelper>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.BusZoneHelpers");

            entity.HasIndex(e => e.BusHelperId, "IX_BusHelperId");

            entity.HasIndex(e => e.BusZoneId, "IX_BusZoneId");

            entity.HasOne(d => d.BusHelper).WithMany(p => p.BusZoneHelpers)
                .HasForeignKey(d => d.BusHelperId)
                .HasConstraintName("FK_dbo.BusZoneHelpers_dbo.BusHelpers_BusHelperId");

            entity.HasOne(d => d.BusZone).WithMany(p => p.BusZoneHelpers)
                .HasForeignKey(d => d.BusZoneId)
                .HasConstraintName("FK_dbo.BusZoneHelpers_dbo.BusZones_BusZoneId");
        });

        modelBuilder.Entity<BusZoneTrip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.BusZoneTrips");

            entity.HasIndex(e => e.BusZoneId, "IX_BusZoneId");

            entity.HasOne(d => d.BusZone).WithMany(p => p.BusZoneTrips)
                .HasForeignKey(d => d.BusZoneId)
                .HasConstraintName("FK_dbo.BusZoneTrips_dbo.BusZones_BusZoneId");
        });

        modelBuilder.Entity<BusZoneTripCheckpoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.BusZoneTripCheckpoints");

            entity.HasIndex(e => e.BusZoneCheckpointId, "IX_BusZoneCheckpointId");

            entity.HasIndex(e => e.BusZoneTripId, "IX_BusZoneTripId");

            entity.HasOne(d => d.BusZoneCheckpoint).WithMany(p => p.BusZoneTripCheckpoints)
                .HasForeignKey(d => d.BusZoneCheckpointId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.BusZoneTripCheckpoints_dbo.BusZoneCheckPoints_BusZoneCheckpointId");

            entity.HasOne(d => d.BusZoneTrip).WithMany(p => p.BusZoneTripCheckpoints)
                .HasForeignKey(d => d.BusZoneTripId)
                .HasConstraintName("FK_dbo.BusZoneTripCheckpoints_dbo.BusZoneTrips_BusZoneTripId");
        });

        modelBuilder.Entity<CalendarEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CalendarEvents");

            entity.HasIndex(e => e.AcademicCalendarId, "IX_AcademicCalendarId");

            entity.HasIndex(e => e.StudentId, "IX_StudentId");

            entity.Property(e => e.EventTypeText).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(200);

            entity.HasOne(d => d.AcademicCalendar).WithMany(p => p.CalendarEvents)
                .HasForeignKey(d => d.AcademicCalendarId)
                .HasConstraintName("FK_dbo.CalendarEvents_dbo.AcademicCalendars_AcademicCalendarId");

            entity.HasOne(d => d.Student).WithMany(p => p.CalendarEvents)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_dbo.CalendarEvents_dbo.Students_StudentId");
        });

        modelBuilder.Entity<CardApprovalRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CardApprovalRequests");

            entity.Property(e => e.ApprovedBy).HasMaxLength(50);
            entity.Property(e => e.CardIdentifier).HasMaxLength(50);
            entity.Property(e => e.RequestedBy).HasMaxLength(50);
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Classes");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<ClassExam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ClassExams");

            entity.HasIndex(e => e.ClassId, "IX_ClassId");

            entity.HasIndex(e => e.ContributionExamId, "IX_ContributionExamId");

            entity.HasIndex(e => e.ExamId, "IX_ExamId");

            entity.HasIndex(e => e.TermId, "IX_TermId");

            entity.Property(e => e.ContributionPercentage).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Class).WithMany(p => p.ClassExams)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK_dbo.ClassExams_dbo.Classes_ClassId");

            entity.HasOne(d => d.ContributionExam).WithMany(p => p.InverseContributionExam)
                .HasForeignKey(d => d.ContributionExamId)
                .HasConstraintName("FK_dbo.ClassExams_dbo.ClassExams_ContributionExamId");

            entity.HasOne(d => d.Exam).WithMany(p => p.ClassExams)
                .HasForeignKey(d => d.ExamId)
                .HasConstraintName("FK_dbo.ClassExams_dbo.Exams_ExamId");

            entity.HasOne(d => d.Term).WithMany(p => p.ClassExams)
                .HasForeignKey(d => d.TermId)
                .HasConstraintName("FK_dbo.ClassExams_dbo.Terms_TermId");
        });

        modelBuilder.Entity<ClassExamAssessmentFullMark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ClassExamAssessmentFullMarks");

            entity.HasIndex(e => e.AssessmentId, "IX_AssessmentId");

            entity.Property(e => e.CreditHours).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FullMarks).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Assessment).WithMany(p => p.ClassExamAssessmentFullMarks)
                .HasForeignKey(d => d.AssessmentId)
                .HasConstraintName("FK_dbo.ClassExamAssessmentFullMarks_dbo.Assessments_AssessmentId");
        });

        modelBuilder.Entity<ClassFee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ClassFees");

            entity.HasIndex(e => e.ClassId, "IX_ClassId");

            entity.Property(e => e.Fee).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Class).WithMany(p => p.ClassFees)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK_dbo.ClassFees_dbo.Classes_ClassId");
        });

        modelBuilder.Entity<Classroom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Classrooms");

            entity.HasIndex(e => e.ClassId, "IX_ClassId");

            entity.HasIndex(e => e.SectionId, "IX_SectionId");

            entity.HasIndex(e => e.ShiftId, "IX_ShiftId");

            entity.HasIndex(e => e.TeacherId, "IX_TeacherId");

            entity.HasOne(d => d.Class).WithMany(p => p.Classrooms)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK_dbo.Classrooms_dbo.Classes_ClassId");

            entity.HasOne(d => d.Section).WithMany(p => p.Classrooms)
                .HasForeignKey(d => d.SectionId)
                .HasConstraintName("FK_dbo.Classrooms_dbo.Sections_SectionId");

            entity.HasOne(d => d.Shift).WithMany(p => p.Classrooms)
                .HasForeignKey(d => d.ShiftId)
                .HasConstraintName("FK_dbo.Classrooms_dbo.Shifts_ShiftId");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Classrooms)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_dbo.Classrooms_dbo.Teachers_TeacherId");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Courses");

            entity.HasIndex(e => e.ClassNameId, "IX_ClassNameId");

            entity.HasOne(d => d.ClassName).WithMany(p => p.Courses)
                .HasForeignKey(d => d.ClassNameId)
                .HasConstraintName("FK_dbo.Courses_dbo.Classes_ClassNameId");
        });

        modelBuilder.Entity<DefaultSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.DefaultSettings");

            entity.Property(e => e.From).HasColumnType("datetime");
            entity.Property(e => e.Smsbalance)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SMSBalance");
            entity.Property(e => e.Smsstatus).HasColumnName("SMSStatus");
            entity.Property(e => e.To).HasColumnType("datetime");
            entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<DeletedReceipt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.DeletedReceipts");

            entity.Property(e => e.ClassroomName).HasMaxLength(120);
            entity.Property(e => e.DeletedAdjustedAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DeletedAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DeletedBy).HasMaxLength(50);
            entity.Property(e => e.StudentName).HasMaxLength(120);
        });

        modelBuilder.Entity<Designation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Designations");
        });

        modelBuilder.Entity<Device>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Devices");
        });

        modelBuilder.Entity<DevicePlacement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.DevicePlacements");

            entity.HasIndex(e => e.DeviceId, "IX_DeviceId");

            entity.HasIndex(e => e.PlacementId, "IX_PlacementId");

            entity.HasOne(d => d.Device).WithMany(p => p.DevicePlacements)
                .HasForeignKey(d => d.DeviceId)
                .HasConstraintName("FK_dbo.DevicePlacements_dbo.Devices_DeviceId");

            entity.HasOne(d => d.Placement).WithMany(p => p.DevicePlacements)
                .HasForeignKey(d => d.PlacementId)
                .HasConstraintName("FK_dbo.DevicePlacements_dbo.Placements_PlacementId");
        });

        modelBuilder.Entity<Diary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Diaries");

            entity.HasIndex(e => e.AcademicCalendarId, "IX_AcademicCalendarId");

            entity.HasOne(d => d.AcademicCalendar).WithMany(p => p.Diaries)
                .HasForeignKey(d => d.AcademicCalendarId)
                .HasConstraintName("FK_dbo.Diaries_dbo.AcademicCalendars_AcademicCalendarId");
        });

        modelBuilder.Entity<DiscountType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.DiscountTypes");

            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<EducationLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.EducationLevels");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Employees");

            entity.HasIndex(e => e.EmployeeDesignationId, "IX_EmployeeDesignationId");

            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Identifier).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ImagePath).HasMaxLength(500);
            entity.Property(e => e.LoginGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Nid).HasColumnName("NID");

            entity.HasOne(d => d.EmployeeDesignation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.EmployeeDesignationId)
                .HasConstraintName("FK_dbo.Employees_dbo.EmployeeDesignations_EmployeeDesignationId");
        });

        modelBuilder.Entity<EmployeeDesignation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.EmployeeDesignations");

            entity.Property(e => e.Name).HasMaxLength(25);
        });

        modelBuilder.Entity<EmployeeEducation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.EmployeeEducations");

            entity.HasIndex(e => e.EducationLevelId, "IX_EducationLevelId");

            entity.HasIndex(e => e.EmployeeId, "IX_EmployeeId");

            entity.HasIndex(e => e.ExamTitleId, "IX_ExamTitleId");

            entity.Property(e => e.Cgpa).HasColumnName("CGPA");

            entity.HasOne(d => d.EducationLevel).WithMany(p => p.EmployeeEducations)
                .HasForeignKey(d => d.EducationLevelId)
                .HasConstraintName("FK_dbo.EmployeeEducations_dbo.EducationLevels_EducationLevelId");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeEducations)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_dbo.EmployeeEducations_dbo.Employees_EmployeeId");

            entity.HasOne(d => d.ExamTitle).WithMany(p => p.EmployeeEducations)
                .HasForeignKey(d => d.ExamTitleId)
                .HasConstraintName("FK_dbo.EmployeeEducations_dbo.ExamTitles_ExamTitleId");
        });

        modelBuilder.Entity<EmploymentHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.EmploymentHistories");

            entity.HasIndex(e => e.EmployeeId, "IX_EmployeeId");

            entity.Property(e => e.From).HasColumnType("datetime");
            entity.Property(e => e.To).HasColumnType("datetime");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmploymentHistories)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_dbo.EmploymentHistories_dbo.Employees_EmployeeId");
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Exams");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<ExamMark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ExamMarks");

            entity.HasIndex(e => e.AdmissionId, "IX_AdmissionId");

            entity.HasIndex(e => e.CourseId, "IX_CourseId");

            entity.HasIndex(e => e.SessionId, "IX_SessionId");

            entity.HasIndex(e => e.StudentClassId, "IX_StudentClassId");

            entity.HasOne(d => d.Admission).WithMany(p => p.ExamMarks)
                .HasForeignKey(d => d.AdmissionId)
                .HasConstraintName("FK_dbo.ExamMarks_dbo.Admissions_AdmissionId");

            entity.HasOne(d => d.Course).WithMany(p => p.ExamMarks)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_dbo.ExamMarks_dbo.Courses_CourseId");

            entity.HasOne(d => d.Session).WithMany(p => p.ExamMarks)
                .HasForeignKey(d => d.SessionId)
                .HasConstraintName("FK_dbo.ExamMarks_dbo.Intakes_SessionId");

            entity.HasOne(d => d.StudentClass).WithMany(p => p.ExamMarks)
                .HasForeignKey(d => d.StudentClassId)
                .HasConstraintName("FK_dbo.ExamMarks_dbo.Classrooms_StudentClassId");
        });

        modelBuilder.Entity<ExamTitle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ExamTitles");

            entity.HasIndex(e => e.EducationLevelId, "IX_EducationLevelId");

            entity.HasOne(d => d.EducationLevel).WithMany(p => p.ExamTitles)
                .HasForeignKey(d => d.EducationLevelId)
                .HasConstraintName("FK_dbo.ExamTitles_dbo.EducationLevels_EducationLevelId");
        });

        modelBuilder.Entity<Faculty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Faculties");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<FlatPayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.FlatPayments");

            entity.Property(e => e.AmountReceived).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<FlatReceipt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.FlatReceipts");

            entity.HasIndex(e => e.AdmissionId, "IX_AdmissionId");

            entity.HasIndex(e => e.ReceiptId, "IX_ReceiptId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DeletedAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DeletedBy).HasMaxLength(50);
            entity.Property(e => e.DeletedById).HasMaxLength(50);
            entity.Property(e => e.ReasonForDeletion).HasMaxLength(1000);

            entity.HasOne(d => d.Admission).WithMany(p => p.FlatReceipts)
                .HasForeignKey(d => d.AdmissionId)
                .HasConstraintName("FK_dbo.FlatReceipts_dbo.Admissions_AdmissionId");

            entity.HasOne(d => d.Receipt).WithMany(p => p.FlatReceipts)
                .HasForeignKey(d => d.ReceiptId)
                .HasConstraintName("FK_dbo.FlatReceipts_dbo.Receipts_ReceiptId");
        });

        modelBuilder.Entity<FoodServiceType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.FoodServiceTypes");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Groups");

            entity.HasIndex(e => e.ParentGroupId, "IX_ParentGroupId");

            entity.Property(e => e.Name).HasMaxLength(500);

            entity.HasOne(d => d.ParentGroup).WithMany(p => p.InverseParentGroup)
                .HasForeignKey(d => d.ParentGroupId)
                .HasConstraintName("FK_dbo.Groups_dbo.Groups_ParentGroupId");
        });

        modelBuilder.Entity<GroupConfiguration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.GroupConfigurations");

            entity.HasIndex(e => e.GroupId, "IX_GroupId");

            entity.Property(e => e.Name).HasMaxLength(500);

            entity.HasOne(d => d.Group).WithMany(p => p.GroupConfigurations)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK_dbo.GroupConfigurations_dbo.Groups_GroupId");
        });

        modelBuilder.Entity<Guardian>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Guardians");

            entity.HasIndex(e => e.GuardianTypeId, "IX_GuardianTypeId");

            entity.HasIndex(e => e.StudentId, "IX_StudentId");

            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Nid)
                .HasMaxLength(100)
                .HasColumnName("NID");
            entity.Property(e => e.Occupation).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);

            entity.HasOne(d => d.GuardianType).WithMany(p => p.Guardians)
                .HasForeignKey(d => d.GuardianTypeId)
                .HasConstraintName("FK_dbo.Guardians_dbo.GuardianTypes_GuardianTypeId");

            entity.HasOne(d => d.Student).WithMany(p => p.Guardians)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_dbo.Guardians_dbo.Students_StudentId");
        });

        modelBuilder.Entity<GuardianExtensionForIndium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.GuardianExtensionForIndia");

            entity.HasIndex(e => e.Id, "IX_Id");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AadharCardNumber).HasMaxLength(12);
            entity.Property(e => e.SssmId).HasMaxLength(12);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.GuardianExtensionForIndium)
                .HasForeignKey<GuardianExtensionForIndium>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.GuardianExtensionForIndia_dbo.Guardians_Id");
        });

        modelBuilder.Entity<GuardianType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.GuardianTypes");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Intake>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Intakes");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Invoices");

            entity.HasIndex(e => e.AdmissionId, "IX_AdmissionId");

            entity.Property(e => e.CancellationReason).HasMaxLength(500);
            entity.Property(e => e.CancelledBy).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.InvoiceStatusText).HasMaxLength(100);
            entity.Property(e => e.Note).HasMaxLength(250);
            entity.Property(e => e.Number).HasMaxLength(50);
            entity.Property(e => e.Period).HasMaxLength(50);
            entity.Property(e => e.PreviousBalance).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Admission).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.AdmissionId)
                .HasConstraintName("FK_dbo.Invoices_dbo.Admissions_AdmissionId");
        });

        modelBuilder.Entity<InvoicedLineItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.InvoicedLineItems");

            entity.HasIndex(e => e.InvoiceId, "IX_InvoiceId");

            entity.HasIndex(e => e.QueuedLineItemId, "IX_QueuedLineItemId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(500);

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoicedLineItems)
                .HasForeignKey(d => d.InvoiceId)
                .HasConstraintName("FK_dbo.InvoicedLineItems_dbo.Invoices_InvoiceId");

            entity.HasOne(d => d.QueuedLineItem).WithMany(p => p.InvoicedLineItems)
                .HasForeignKey(d => d.QueuedLineItemId)
                .HasConstraintName("FK_dbo.InvoicedLineItems_dbo.QueuedLineItems_QueuedLineItemId");
        });

        modelBuilder.Entity<InvoicedLineItemPayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.InvoicedLineItemPayments");

            entity.HasIndex(e => e.InvoicedLineItemId, "IX_InvoicedLineItemId");

            entity.HasIndex(e => e.ReceiptId, "IX_ReceiptId");

            entity.Property(e => e.AllocatedBy).HasMaxLength(50);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProcessedBy).HasMaxLength(50);

            entity.HasOne(d => d.InvoicedLineItem).WithMany(p => p.InvoicedLineItemPayments)
                .HasForeignKey(d => d.InvoicedLineItemId)
                .HasConstraintName("FK_dbo.InvoicedLineItemPayments_dbo.InvoicedLineItems_InvoicedLineItemId");

            entity.HasOne(d => d.Receipt).WithMany(p => p.InvoicedLineItemPayments)
                .HasForeignKey(d => d.ReceiptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.InvoicedLineItemPayments_dbo.Receipts_ReceiptId");
        });

        modelBuilder.Entity<JobInformation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.JobInformations");

            entity.HasIndex(e => e.DesignationId, "IX_DesignationId");

            entity.HasIndex(e => e.EmployeeId, "IX_EmployeeId");

            entity.Property(e => e.Doj)
                .HasColumnType("datetime")
                .HasColumnName("DOJ");
            entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Designation).WithMany(p => p.JobInformations)
                .HasForeignKey(d => d.DesignationId)
                .HasConstraintName("FK_dbo.JobInformations_dbo.Designations_DesignationId");

            entity.HasOne(d => d.Employee).WithMany(p => p.JobInformations)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_dbo.JobInformations_dbo.Employees_EmployeeId");
        });

        modelBuilder.Entity<Ledger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Ledgers");

            entity.HasIndex(e => e.GroupId, "IX_GroupId");

            entity.Property(e => e.Name).HasMaxLength(500);

            entity.HasOne(d => d.Group).WithMany(p => p.Ledgers)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK_dbo.Ledgers_dbo.Groups_GroupId");
        });

        modelBuilder.Entity<LedgerPeriod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.LedgerPeriods");

            entity.HasIndex(e => e.LedgerId, "IX_LedgerId");

            entity.Property(e => e.ClosingBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Ledger).WithMany(p => p.LedgerPeriods)
                .HasForeignKey(d => d.LedgerId)
                .HasConstraintName("FK_dbo.LedgerPeriods_dbo.Ledgers_LedgerId");
        });

        modelBuilder.Entity<LedgerPeriodConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.LedgerPeriodConfigs");
        });

        modelBuilder.Entity<LedgerStatement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.LedgerStatements");

            entity.HasIndex(e => e.LedgerPeriodId, "IX_LedgerPeriodId");

            entity.HasIndex(e => e.VoucherEntryId, "IX_VoucherEntryId");

            entity.HasOne(d => d.LedgerPeriod).WithMany(p => p.LedgerStatements)
                .HasForeignKey(d => d.LedgerPeriodId)
                .HasConstraintName("FK_dbo.LedgerStatements_dbo.LedgerPeriods_LedgerPeriodId");

            entity.HasOne(d => d.VoucherEntry).WithMany(p => p.LedgerStatements)
                .HasForeignKey(d => d.VoucherEntryId)
                .HasConstraintName("FK_dbo.LedgerStatements_dbo.VoucherEntries_VoucherEntryId");
        });

        modelBuilder.Entity<LineItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.LineItems");

            entity.Property(e => e.CategoryText).HasMaxLength(100);
            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(20);
        });

        modelBuilder.Entity<Lookup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Lookups");

            entity.Property(e => e.Name).HasMaxLength(500);
        });

        modelBuilder.Entity<Marksheet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Marksheets");

            entity.HasIndex(e => e.AdmissionId, "IX_AdmissionId");

            entity.HasIndex(e => e.ClassExamId, "IX_ClassExamId");

            entity.Property(e => e.Remarks).HasMaxLength(1000);

            entity.HasOne(d => d.Admission).WithMany(p => p.Marksheets)
                .HasForeignKey(d => d.AdmissionId)
                .HasConstraintName("FK_dbo.Marksheets_dbo.Admissions_AdmissionId");

            entity.HasOne(d => d.ClassExam).WithMany(p => p.Marksheets)
                .HasForeignKey(d => d.ClassExamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Marksheets_dbo.ClassExams_ClassExamId");
        });

        modelBuilder.Entity<MarksheetAssessment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.MarksheetAssessments");

            entity.HasIndex(e => e.AssessmentId, "IX_AssessmentId");

            entity.HasIndex(e => e.MarksheetId, "IX_MarksheetId");

            entity.Property(e => e.ObtainedMarks).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remark).HasMaxLength(1000);

            entity.HasOne(d => d.Assessment).WithMany(p => p.MarksheetAssessments)
                .HasForeignKey(d => d.AssessmentId)
                .HasConstraintName("FK_dbo.MarksheetAssessments_dbo.Assessments_AssessmentId");

            entity.HasOne(d => d.Marksheet).WithMany(p => p.MarksheetAssessments)
                .HasForeignKey(d => d.MarksheetId)
                .HasConstraintName("FK_dbo.MarksheetAssessments_dbo.Marksheets_MarksheetId");
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Notice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Notices");

            entity.HasIndex(e => e.AcademicCalendarId, "IX_AcademicCalendarId");

            entity.HasOne(d => d.AcademicCalendar).WithMany(p => p.Notices)
                .HasForeignKey(d => d.AcademicCalendarId)
                .HasConstraintName("FK_dbo.Notices_dbo.AcademicCalendars_AcademicCalendarId");
        });

        modelBuilder.Entity<Placement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Placements");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PlacementType).HasMaxLength(100);
        });

        modelBuilder.Entity<PromptAcknowledgment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PromptAcknowledgments");

            entity.Property(e => e.AcknowledgedBy).HasMaxLength(200);
            entity.Property(e => e.AcknowledgementForValueId).HasMaxLength(150);
            entity.Property(e => e.PromptAcknowledgementForText).HasMaxLength(500);
            entity.Property(e => e.PromptUrl).HasMaxLength(2500);
        });

        modelBuilder.Entity<Punch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Punches");
        });

        modelBuilder.Entity<PunchCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PunchCards");

            entity.HasIndex(e => e.PlacementId, "IX_PlacementId");

            entity.Property(e => e.ProcessedBy).HasMaxLength(200);

            entity.HasOne(d => d.Placement).WithMany(p => p.PunchCards)
                .HasForeignKey(d => d.PlacementId)
                .HasConstraintName("FK_dbo.PunchCards_dbo.Placements_PlacementId");
        });

        modelBuilder.Entity<QueuedLineItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.QueuedLineItems");

            entity.HasIndex(e => e.LineItemId, "IX_LineItemId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LineItemTypeText).HasMaxLength(100);
            entity.Property(e => e.QueueLevelText).HasMaxLength(100);
            entity.Property(e => e.QueueLevelValueDisplay).HasMaxLength(100);
            entity.Property(e => e.RecurringTypeText).HasMaxLength(100);
            entity.Property(e => e.SubLineItem).HasMaxLength(20);

            entity.HasOne(d => d.LineItem).WithMany(p => p.QueuedLineItems)
                .HasForeignKey(d => d.LineItemId)
                .HasConstraintName("FK_dbo.QueuedLineItems_dbo.LineItems_LineItemId");
        });

        modelBuilder.Entity<Receipt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Receipts");

            entity.HasIndex(e => e.InvoiceId, "IX_InvoiceId");

            entity.Property(e => e.AdjustedAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DeletedAdjustedAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DeletedAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DeletedBy).HasMaxLength(50);
            entity.Property(e => e.DeletedById).HasMaxLength(50);
            entity.Property(e => e.InvoicedLineItemsAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Note).HasMaxLength(500);
            entity.Property(e => e.Number).HasMaxLength(50);
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidBy)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentMethodText).HasMaxLength(100);
            entity.Property(e => e.PreviousBalanceAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReasonForDeletion).HasMaxLength(1000);
            entity.Property(e => e.Remarks).HasMaxLength(500);

            entity.HasOne(d => d.Invoice).WithMany(p => p.Receipts)
                .HasForeignKey(d => d.InvoiceId)
                .HasConstraintName("FK_dbo.Receipts_dbo.Invoices_InvoiceId");
        });

        modelBuilder.Entity<ReferenceSubject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ReferenceSubjects");

            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Resource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Resources");

            entity.Property(e => e.Tags).HasMaxLength(400);
            entity.Property(e => e.UploadedBy).HasMaxLength(20);
            entity.Property(e => e.Url).HasMaxLength(800);
        });

        modelBuilder.Entity<School>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Schools");

            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.AffiliationNumber).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.ExternalReferenceId).HasMaxLength(1000);
            entity.Property(e => e.Fax).HasMaxLength(100);
            entity.Property(e => e.ImagePath).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.PhoneAlt).HasMaxLength(100);
            entity.Property(e => e.PhonePrimary).HasMaxLength(100);
            entity.Property(e => e.SchoolCode).HasMaxLength(100);
            entity.Property(e => e.Theme).HasMaxLength(50);
        });

        modelBuilder.Entity<Section>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Sections");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Shift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Shifts");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Students");

            entity.Property(e => e.ContactNumber).HasMaxLength(10);
            entity.Property(e => e.DoctorContactNumber).HasMaxLength(50);
            entity.Property(e => e.DoctorName).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.Identifier).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ImagePath).HasMaxLength(500);
            entity.Property(e => e.LastName).HasMaxLength(20);
            entity.Property(e => e.MiddleName).HasMaxLength(20);
            entity.Property(e => e.PermanentAddress).HasMaxLength(250);
            entity.Property(e => e.PlaceOfBirth).HasMaxLength(20);
            entity.Property(e => e.PostcodeOrWard).HasMaxLength(20);
            entity.Property(e => e.StateOrProvince).HasMaxLength(50);
            entity.Property(e => e.Street).HasMaxLength(100);
            entity.Property(e => e.SuburbOrCity).HasMaxLength(50);
        });

        modelBuilder.Entity<StudentCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.StudentCards");

            entity.HasIndex(e => e.StudentId, "IX_StudentId");

            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.Identifier).HasMaxLength(50);

            entity.HasOne(d => d.Student).WithMany(p => p.StudentCards)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_dbo.StudentCards_dbo.Students_StudentId");
        });

        modelBuilder.Entity<StudentDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.StudentDocuments");

            entity.HasIndex(e => e.StudentId, "IX_StudentId");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentDocuments)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_dbo.StudentDocuments_dbo.Students_StudentId");
        });

        modelBuilder.Entity<StudentExtensionForIndium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.StudentExtensionForIndia");

            entity.HasIndex(e => e.Id, "IX_Id");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AadharCardNumber).HasMaxLength(20);
            entity.Property(e => e.BankAccountNumber).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(150);
            entity.Property(e => e.FamilySssmId).HasMaxLength(20);
            entity.Property(e => e.Ifsc).HasMaxLength(50);
            entity.Property(e => e.PanCardNumber).HasMaxLength(50);
            entity.Property(e => e.Pen)
                .HasMaxLength(50)
                .HasColumnName("PEN");
            entity.Property(e => e.ScholarNumber).HasMaxLength(20);
            entity.Property(e => e.SssmId).HasMaxLength(20);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.StudentExtensionForIndium)
                .HasForeignKey<StudentExtensionForIndium>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.StudentExtensionForIndia_dbo.Students_Id");
        });

        modelBuilder.Entity<StudentSubject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.StudentSubjects");

            entity.HasIndex(e => e.AdmissionId, "IX_AdmissionId");

            entity.HasIndex(e => e.SubjectId, "IX_SubjectId");

            entity.HasOne(d => d.Admission).WithMany(p => p.StudentSubjects)
                .HasForeignKey(d => d.AdmissionId)
                .HasConstraintName("FK_dbo.StudentSubjects_dbo.Admissions_AdmissionId");

            entity.HasOne(d => d.Subject).WithMany(p => p.StudentSubjects)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_dbo.StudentSubjects_dbo.Subjects_SubjectId");
        });

        modelBuilder.Entity<StudentsBkpBfrImgDel13may24>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("students_bkp_bfr_img_del_13may24");

            entity.Property(e => e.DoctorContactNumber).HasMaxLength(50);
            entity.Property(e => e.DoctorName).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ImagePath).HasMaxLength(500);
            entity.Property(e => e.LastName).HasMaxLength(20);
            entity.Property(e => e.MiddleName).HasMaxLength(20);
            entity.Property(e => e.PermanentAddress).HasMaxLength(250);
            entity.Property(e => e.PostcodeOrWard).HasMaxLength(20);
            entity.Property(e => e.StateOrProvince).HasMaxLength(50);
            entity.Property(e => e.Street).HasMaxLength(100);
            entity.Property(e => e.SuburbOrCity).HasMaxLength(50);
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Subjects");

            entity.HasIndex(e => e.ClassId, "IX_ClassId");

            entity.HasIndex(e => e.ReferenceSubjectId, "IX_ReferenceSubject_Id");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsEca).HasColumnName("IsECA");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ReferenceSubjectCode).HasMaxLength(5);
            entity.Property(e => e.ReferenceSubjectId).HasColumnName("ReferenceSubject_Id");

            entity.HasOne(d => d.Class).WithMany(p => p.Subjects)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK_dbo.Subjects_dbo.Classes_ClassId");

            entity.HasOne(d => d.ReferenceSubject).WithMany(p => p.Subjects)
                .HasForeignKey(d => d.ReferenceSubjectId)
                .HasConstraintName("FK_dbo.Subjects_dbo.CoreSubjects_CoreSubjectId");
        });

        modelBuilder.Entity<SubjectTeacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.SubjectTeachers");

            entity.HasIndex(e => e.SubjectId, "IX_SubjectId");

            entity.HasIndex(e => e.TeacherId, "IX_TeacherId");

            entity.HasOne(d => d.Subject).WithMany(p => p.SubjectTeachers)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_dbo.SubjectTeachers_dbo.Subjects_SubjectId");

            entity.HasOne(d => d.Teacher).WithMany(p => p.SubjectTeachers)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_dbo.SubjectTeachers_dbo.Teachers_TeacherId");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Teachers");

            entity.HasIndex(e => e.EmployeeId, "IX_EmployeeId");

            entity.HasOne(d => d.Employee).WithMany(p => p.Teachers)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_dbo.Teachers_dbo.Employees_EmployeeId");
        });

        modelBuilder.Entity<Temp2081StudentIdPhotoDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_2081_student_id_photo_detail");

            entity.Property(e => e.Admissionid).HasColumnName("admissionid");
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.LastName).HasMaxLength(20);
            entity.Property(e => e.MiddleName).HasMaxLength(20);
            entity.Property(e => e.Studentid).HasColumnName("studentid");
            entity.Property(e => e.Studentnumber)
                .HasMaxLength(100)
                .HasColumnName("studentnumber");
        });

        modelBuilder.Entity<Term>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Terms");

            entity.HasIndex(e => e.AcademiccalendarId, "IX_AcademiccalendarId");

            entity.HasOne(d => d.Academiccalendar).WithMany(p => p.Terms)
                .HasForeignKey(d => d.AcademiccalendarId)
                .HasConstraintName("FK_dbo.Terms_dbo.AcademicCalendars_AcademiccalendarId");
        });

        modelBuilder.Entity<TransferCertificate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TransferCertificates");

            entity.HasIndex(e => e.AdmissionId, "IX_AdmissionId");

            entity.HasOne(d => d.Admission).WithMany(p => p.TransferCertificates)
                .HasForeignKey(d => d.AdmissionId)
                .HasConstraintName("FK_dbo.TransferCertificates_dbo.Admissions_AdmissionId");
        });

        modelBuilder.Entity<VoucherEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.VoucherEntries");

            entity.HasIndex(e => e.ParentVoucherEntryId, "IX_ParentVoucherEntryId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.ParentVoucherEntry).WithMany(p => p.InverseParentVoucherEntry)
                .HasForeignKey(d => d.ParentVoucherEntryId)
                .HasConstraintName("FK_dbo.VoucherEntries_dbo.VoucherEntries_ParentVoucherEntryId");
        });

        modelBuilder.Entity<VoucherEntryDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.VoucherEntryDetails");

            entity.HasIndex(e => e.VoucherEntryId, "IX_VoucherEntryId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.VoucherEntry).WithMany(p => p.VoucherEntryDetails)
                .HasForeignKey(d => d.VoucherEntryId)
                .HasConstraintName("FK_dbo.VoucherEntryDetails_dbo.VoucherEntries_VoucherEntryId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
