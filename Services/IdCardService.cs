using Microsoft.AspNetCore.Mvc;
using Net.Codecrete.QrCodeGenerator;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using REPLSolutions_IDGenerator.Models;
using REPLSolutions_IDGenerator.Services;

public class IdCardService : IIdCardService
{
    public enum IdCardDesign
    {
        Default,
        Template2,
        Template3,
        Template4,
        Template5,
        Template6,
        Template7,
        Template8,
        Template9,
        Template10,
        Template11,
        Template12
    }

    public byte[] GenerateIdCard(Student student, School school, IdCardDesign design = IdCardDesign.Default)
    {
        switch (design)
        {
            case IdCardDesign.Template2:
                return GenerateTemplate2(student, school);
            case IdCardDesign.Template3:
                return GenerateTemplate3(student, school);
            case IdCardDesign.Template4:
                return GenerateTemplate4(student, school);
            case IdCardDesign.Template5:
                return GenerateTemplate5(student, school);
            case IdCardDesign.Template6:
                return GenerateTemplate6(student, school);
            case IdCardDesign.Template7:
                return GenerateTemplate7(student, school);
            case IdCardDesign.Template8:
                return GenerateTemplate8(student, school);
            case IdCardDesign.Template9:
                return GenerateTemplate9(student, school);
            case IdCardDesign.Template10:
                return GenerateTemplate10(student, school);
            case IdCardDesign.Template11:
                return GenerateTemplate11(student, school);
            case IdCardDesign.Template12:
                return GenerateTemplate12(student, school);
            default:
                return GenerateDefaultTemplate(student, school);
        }
    }

    private byte[] GenerateDefaultTemplate(Student student, School school)
    {
        string tealColor = "#00A5B5";
        string blueColor = "#2B82C9";

        var admission = student.Admissions.FirstOrDefault();
        string guardianName = student.Guardians.FirstOrDefault()?.Name ?? "N/A";
        string guardianPhone = student.Guardians.FirstOrDefault()?.Phone ?? "N/A";
        string address = student.Guardians.FirstOrDefault()?.Address ?? "N/A";
        DateTimeOffset? cardValidityDate = CalculateCardValidityDate(admission?.AdmissionDate);

        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(55, 86, Unit.Millimetre);
                page.Margin(0);
                page.DefaultTextStyle(x => x.FontSize(7));

                page.Header().StopPaging().Column(headerCol =>
                {
                    headerCol.Item().Background(blueColor).Row(row =>
                    {
                        row.AutoItem().Height(35).Width(35).PaddingLeft(4).Image("wwwroot/images/logo.png").FitArea();

                        row.RelativeItem().AlignMiddle().Column(column =>
                        {
                            column.Item().Text("REPL ENGLISH BOARDING SCHOOL")
                                .FontSize(9)
                                .Bold()
                                .FontColor(Colors.White)
                                .AlignCenter()
                                .ClampLines(1, "");

                            column.Item().Text(school.Address)
                                .FontSize(8)
                                .FontColor(Colors.White)
                                .AlignCenter()
                                .ClampLines(1, "");
                        });
                    });
                });

                page.Content()
                    .PaddingHorizontal(10)
                    .PaddingVertical(3)
                    .StopPaging()
                    .Column(col =>
                    {
                        col.Item().AlignCenter().Background(blueColor).Padding(2).Element(container =>
                        {
                            container.AlignCenter().Text("STUDENT ID CARD")
                                .FontSize(8)
                                .Bold()
                                .FontColor(Colors.White);
                        });

                        col.Item().AlignCenter().Padding(2).PaddingTop(5).Row(row =>
                        {
                            row.AutoItem().AlignMiddle().Element(container =>
                            {
                                if (student.Image != null)
                                {
                                    container.Width(65).Height(65)
                                        .AlignCenter()
                                        .Border(2)
                                        .BorderColor(Colors.White)
                                        .Image(student.Image)
                                        .FitArea();
                                }
                                else
                                {
                                    container.Width(65).Height(65)
                                        .Border(2)
                                        .BorderColor(Colors.White)
                                        .Background(Colors.Grey.Lighten3)
                                        .AlignMiddle()
                                        .AlignCenter()
                                        .Text("Photo");
                                }
                            });

                            row.AutoItem().AlignMiddle().Width(65).Height(65).Svg(GenerateQrCode(
                                $"Name: {student.FirstName ?? "N/A"} {student.LastName ?? "N/A"}, " +
                                $"Phone: {student.Guardians.FirstOrDefault()?.Phone ?? "N/A"}, " +
                                $"Address: {student.Guardians.FirstOrDefault()?.Address ?? "N/A"}"
                            ));
                        });

                        col.Item().AlignCenter().Row(row =>
                        {
                            row.RelativeItem().AlignMiddle().Height(1).Background(tealColor);
                            row.ConstantItem(100).AlignCenter().Text(student.FirstName + " " + student.LastName)
                            .FontSize(9).Bold().FontColor(Colors.Black).ClampLines(1, "");
                            row.RelativeItem().AlignMiddle().Height(1).Background(tealColor);
                        });

                        col.Item().PaddingVertical(4).PaddingHorizontal(6).AlignCenter().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(1);
                                columns.ConstantColumn(5);
                                columns.RelativeColumn(2);
                            });

                            void AddRow(string label, string value)
                            {
                                table.Cell().Text(label).Bold().ClampLines(1, "");
                                table.Cell().Text(":");
                                table.Cell().Text(value).ClampLines(1, "");
                            }

                            AddRow("Roll No", student.Admissions.FirstOrDefault()?.RollNumber ?? "N/A");
                            AddRow("Class", admission?.Class.Name ?? "N/A");
                            AddRow("Phone", guardianPhone ?? "N/A");
                            AddRow("Email", student.Email ?? "N/A");
                            AddRow("DOB", student.DateOfBirth.ToString("yyyy-MM-dd") ?? "N/A");
                            AddRow("Address", "Dadhikot, Bhaktapur, Nepal");
                            AddRow("Guardian", guardianName ?? "N/A");
                            AddRow("Validity", cardValidityDate?.ToString("yyyy-MM-dd") ?? "N/A");
                        });

                        col.Item().AlignRight().Width(45).Height(10).Column(column =>
                        {
                            column.Item().Text("Principal's Sign")
                                .FontSize(5)
                                .FontColor(Colors.Black)
                                .AlignCenter();

                            column.Item().Height(1)
                                .Background(Colors.Black);
                        });
                    });

                page.Footer().StopPaging().Background(blueColor).Padding(3).AlignCenter()
                    .Text(text =>
                    {
                        text.ClampLines(1, "");
                        text.Span("OUR SCHOOL, OUR PRIDE")
                            .FontColor(Colors.White).FontSize(7).Italic();
                    });
            });
        }).GeneratePdf();
    }

    private byte[] GenerateTemplate2(Student student, School school)
    {
        string deeporangeColor = "#D84315";
        string greenColor = "#22B14C";

        var admission = student.Admissions.FirstOrDefault();
        string guardianName = student.Guardians.FirstOrDefault()?.Name ?? "N/A";
        string guardianPhone = student.Guardians.FirstOrDefault()?.Phone ?? "N/A";
        string address = student.Guardians.FirstOrDefault()?.Address ?? "N/A";
        DateTimeOffset? cardValidityDate = CalculateCardValidityDate(admission?.AdmissionDate);

        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(55, 86, Unit.Millimetre);
                page.Margin(2);
                page.DefaultTextStyle(x => x.FontSize(7));

                page.Background().Image("wwwroot/images/template2_bg.png").FitArea();

                page.Header().StopPaging().AlignCenter().AlignMiddle().Column(headerCol =>
                {
                    headerCol.Item().PaddingTop(20).Row(row =>
                    {
                        row.AutoItem().PaddingLeft(10).Width(28).Height(28)
                            .Image("wwwroot/images/template2_logo.png").FitArea();

                        row.RelativeItem().Column(column =>
                        {
                            column.Item().Text("REPL ENGLISH BOARDING SCHOOL")
                                .FontSize(8)
                                .Bold()
                                .FontColor(greenColor)
                                .ClampLines(1, "");

                            column.Item().Text(school.Address)
                               .FontSize(6)
                               .FontColor(Colors.Grey.Darken2)
                               .ClampLines(1, "");

                            column.Item().Text(school.PhonePrimary)
                                .FontSize(6)
                                .FontColor(Colors.Grey.Darken2)
                                .ClampLines(1, "");
                        });
                    });

                    headerCol.Item().PaddingVertical(7).AlignCenter().Text("STUDENT ID CARD")
                        .FontSize(8)
                        .Bold()
                        .FontColor(deeporangeColor);
                });

                page.Content().StopPaging().Column(col =>
                {
                    col.Item().Row(row =>
                    {
                        row.AutoItem().AlignMiddle().Width(60).Height(60)
                            .Svg(GenerateQrCode(
                                $"Name: {student.FirstName ?? "N/A"} {student.LastName ?? "N/A"}, " +
                                $"Class: {admission?.Class.Name ?? "N/A"}, " +
                                $"Guardian: {guardianName}, " +
                                $"Phone: {guardianPhone}, " +
                                $"Address: {address}"
                            ));

                        row.RelativeItem().AlignMiddle().Element(container =>
                        {
                            if (student.Image != null)
                            {
                                container.Width(60).Height(60)
                                    .Border(1)
                                    .BorderColor(Colors.Grey.Darken2)
                                    .Image(student.Image)
                                    .FitArea();
                            }
                            else
                            {
                                container.Width(60).Height(60)
                                    .Border(1)
                                    .BorderColor(Colors.Grey.Darken2)
                                    .Background(Colors.Grey.Lighten3)
                                    .AlignMiddle()
                                    .AlignCenter()
                                    .Text("Photo")
                                    .FontSize(6)
                                    .Italic()
                                    .FontColor(Colors.Grey.Darken1);
                            }
                        });

                        row.AutoItem().AlignBottom().PaddingRight(2).Width(20).Height(10).Column(column =>
                        {
                            column.Item().Text("Principal")
                                .FontSize(5)
                                .FontColor(Colors.Black)
                                .AlignCenter();

                            column.Item().AlignBottom().Height(1)
                                .Background(Colors.Black);
                        });
                    });

                    col.Item().PaddingTop(6).AlignCenter().Text($"{student.FirstName} {student.LastName}")
                        .FontSize(10)
                        .Bold()
                        .FontColor(greenColor)
                        .ClampLines(1, "");

                    col.Item().PaddingVertical(6).PaddingHorizontal(15).Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn(1);
                            columns.ConstantColumn(5);
                            columns.RelativeColumn(2);
                        });

                        void AddRow(string label, string value)
                        {
                            table.Cell().Text(label).Bold().ClampLines(1, "");
                            table.Cell().Text(":");
                            table.Cell().Text(value).ClampLines(1, "");
                        }

                        AddRow("Class", admission?.Class.Name ?? "N/A");
                        AddRow("Roll No", student.Admissions.FirstOrDefault()?.RollNumber ?? "N/A");
                        AddRow("DOB", student.DateOfBirth.ToString("yyyy-MM-dd") ?? "N/A");
                        AddRow("Contact", guardianPhone);
                        AddRow("Guardian", guardianName);
                        AddRow("Address", "Kathmandu, Bagmati, Nepal");
                        AddRow("Validity", cardValidityDate?.ToString("yyyy-MM-dd") ?? "N/A");
                    });
                });
            });
        }).GeneratePdf();
    }

    private byte[] GenerateTemplate3(Student student, School school)
    {
        string blueColor = "#3F48CC";
        string orangeColor = "#F8A424";
        string redColor = "#E74C3C";

        var admission = student.Admissions.FirstOrDefault();
        string guardianName = student.Guardians.FirstOrDefault()?.Name ?? "N/A";
        string guardianPhone = student.Guardians.FirstOrDefault()?.Phone ?? "N/A";
        string address = student.Guardians.FirstOrDefault()?.Address ?? "N/A";
        DateTimeOffset? cardValidityDate = CalculateCardValidityDate(admission?.AdmissionDate);


        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(55, 86, Unit.Millimetre);
                page.Margin(0);
                page.DefaultTextStyle(x => x.FontSize(7));

                page.Header().StopPaging().Column(headerCol =>
                {
                    headerCol.Item().Background(blueColor).Height(7);

                    headerCol.Item().Background(Colors.White).Padding(1).Column(column =>
                    {
                        column.Item().AlignCenter().Height(28).Width(28).Element(e =>
                        {
                            e.Image("wwwroot/images/template3_logo.png")
                              .FitHeight();
                        });

                        column.Item().Padding(2).AlignCenter().Text("REPL ENGLISH HIGHER BOARDING SCHOOL")
                            .FontSize(9)
                            .Bold()
                            .FontColor(blueColor)
                            .ClampLines(1, "");
                    });

                    headerCol.Item().Background(orangeColor).Padding(2).Element(container =>
                    {
                        container.AlignCenter().Text("STUDENT ID CARD")
                            .FontSize(7)
                            .Bold()
                            .FontColor(Colors.White);
                    });
                });

                page.Content()
                .StopPaging()
                    .PaddingHorizontal(10)
                    .PaddingTop(5)
                    .Column(col =>
                    {
                        col.Item().AlignCenter().Row(row =>
                        {
                            row.AutoItem().AlignMiddle().Element(container =>
                            {
                                if (student.Image != null)
                                {
                                    container.Width(60).Height(60)
                                        .Border(1)
                                        .BorderColor(blueColor)
                                        .Image(student.Image)
                                        .FitArea();
                                }
                                else
                                {
                                    container.Width(60).Height(60)
                                        .Border(1)
                                        .BorderColor(blueColor)
                                        .Background(Colors.Grey.Lighten3)
                                        .AlignMiddle()
                                        .AlignCenter()
                                        .Text("Photo");
                                }
                            });

                            row.AutoItem().AlignMiddle().PaddingLeft(5).Width(65).Height(65).Svg(GenerateQrCode(
                                $"Name: {student.FirstName ?? "N/A"} {student.LastName ?? "N/A"}, " +
                                $"Guardian: {guardianName}, " +
                                $"Phone: {guardianPhone}, " +
                                $"Address: {address}"
                            ));
                        });

                        col.Item().AlignCenter().PaddingTop(1).Column(column =>
                        {
                            column.Item().AlignCenter().Text("Principal Signature")
                                .FontSize(5);
                        });

                        col.Item().PaddingTop(3).AlignCenter().Text($"{student.FirstName} {student.LastName}")
                            .FontSize(9)
                            .Bold()
                            .FontColor(blueColor)
                            .ClampLines(1, "");

                        col.Item().PaddingTop(3).PaddingLeft(3).Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(1);
                                columns.ConstantColumn(5);
                                columns.RelativeColumn(2);
                            });

                            void AddRow(string label, string value)
                            {
                                table.Cell().Text(label).Bold().ClampLines(1, "");
                                table.Cell().Text(":");
                                table.Cell().Text(value).ClampLines(1, "");
                            }

                            AddRow("DOB", student.DateOfBirth.ToString("yyyy-MM-dd") ?? "N/A");
                            AddRow("Grade", admission?.Class.Name ?? "N/A");
                            AddRow("Roll No.", admission?.RollNumber ?? "N/A");
                            AddRow("Address", "Kathmandu, Bagmati, Nepal");
                            AddRow("Contact No.", guardianPhone);
                            AddRow("Guardian", guardianName);
                        });

                        col.Item().PaddingTop(4).AlignCenter().Text($"VALID UP TO : {cardValidityDate?.ToString("yyyy-MM-dd") ?? "N/A"}")
                            .FontSize(6)
                            .Bold()
                            .FontColor(redColor)
                            .ClampLines(1, "");
                    });

                page.Footer().StopPaging().Element(footer =>
                {
                    footer.Background(blueColor)
                        .AlignCenter()
                        .Column(column =>
                        {
                            column.Item().Text(school.Address)
                                .FontSize(6)
                                .AlignCenter()
                                .FontColor(Colors.White)
                                .ClampLines(1, "");

                            column.Item().PaddingBottom(1).Text(school.PhonePrimary)
                                .FontSize(6)
                                .AlignCenter()
                                .FontColor(Colors.White)
                                .ClampLines(1, "");
                        });
                });
            });
        }).GeneratePdf();
    }

    private byte[] GenerateTemplate4(Student student, School school)
    {
        string darkBlue = "#003366";

        var admission = student.Admissions.FirstOrDefault();
        string guardianName = student.Guardians.FirstOrDefault()?.Name ?? "N/A";
        string guardianPhone = student.Guardians.FirstOrDefault()?.Phone ?? "N/A";
        string address = student.Guardians.FirstOrDefault()?.Address ?? "N/A";
        DateTimeOffset? cardValidityDate = CalculateCardValidityDate(admission?.AdmissionDate);

        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(55, 86, Unit.Millimetre);
                page.Margin(0);
                page.DefaultTextStyle(x => x.FontSize(7));

                page.Background().Image("wwwroot/images/template4_bg.png").FitWidth();

                page.Header().StopPaging().Padding(4).Column(header =>
                {
                    header.Item().AlignCenter().Row(row =>
                    {
                        row.AutoItem().PaddingLeft(5).Width(35).Height(30).Image("wwwroot/images/logo.png").FitArea();
                        row.RelativeItem().Column(col =>
                        {
                            col.Item().Text("REPL ENGLISH BOARDING SCHOOL").FontSize(9).Bold().FontColor(Colors.White).ClampLines(1, "");
                            col.Item().Text(school.Address).FontSize(7).FontColor(Colors.White).ClampLines(1, "");
                            col.Item().Text(school.PhonePrimary).FontSize(7).FontColor(Colors.White).ClampLines(1, "");
                            col.Item().Text($"www.{school.Name.Replace(" ", "").ToLower()}.edu.np").FontColor(Colors.White).FontSize(6).ClampLines(1, "");
                        });
                    });

                    header.Item().PaddingTop(7).AlignCenter().Padding(2).Text("STUDENT ID CARD")
                        .FontSize(7).Bold().FontColor(Colors.White);
                });

                page.Content().StopPaging().Padding(4).PaddingLeft(10).Column(col =>
                {
                    col.Item().Row(row =>
                    {
                        row.AutoItem().Element(container =>
                        {
                            if (student.Image != null)
                            {
                                container.Width(60).Height(60)
                                    .Border(1)
                                    .BorderColor(darkBlue)
                                    .Image(student.Image)
                                    .FitArea();
                            }
                            else
                            {
                                container.Width(60).Height(60)
                                    .Border(1)
                                    .BorderColor(darkBlue)
                                    .Background(Colors.Grey.Lighten3)
                                    .AlignMiddle()
                                    .AlignCenter()
                                    .Text("Photo");
                            }
                        });

                        row.RelativeItem().PaddingLeft(6).AlignMiddle().Width(60).Height(60).Svg(GenerateQrCode(
                            $"Name: {student.FirstName} {student.LastName}, Class: {admission?.Class.Name}, Phone: {guardianPhone}, Address: {address}"
                        ));
                    });

                    col.Item().PaddingTop(2).AlignCenter().Text($"{student.FirstName} {student.LastName}")
                        .FontSize(10).Bold().FontColor(darkBlue).ClampLines(1, "");

                    col.Item().PaddingTop(3).Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn(4);
                            columns.ConstantColumn(5);
                            columns.RelativeColumn(10);
                        });

                        void AddRow(string label, string value)
                        {
                            table.Cell().Text(label).Bold().ClampLines(1, "");
                            table.Cell().Text(":");
                            table.Cell().Text(value).ClampLines(1, "");
                        }

                        AddRow("Roll No", admission?.RollNumber ?? "N/A");
                        AddRow("Grade", admission?.Class.Name ?? "N/A");
                        AddRow("Guardian", guardianName);
                        AddRow("Contact", guardianPhone);
                        AddRow("Email", student.Email ?? "N/A");
                        AddRow("DOB", student.DateOfBirth.ToString("dd MMM yyyy"));
                        AddRow("Address", "Kathmandu, Bagmati, Nepal");
                        AddRow("Validity", cardValidityDate?.ToString("dd MMM yyyy") ?? "N/A");
                    });

                    col.Item().PaddingTop(4).AlignCenter().Text("Principal Signature")
                        .FontSize(6).Italic();
                });

                page.Footer().StopPaging().Padding(2).AlignCenter().Text(text =>
                {
                    text.ClampLines(1, "");
                    text.Line("If found, please return to the school").FontColor(Colors.White).FontSize(6);
                });
            });
        }).GeneratePdf();
    }

    private byte[] GenerateTemplate5(Student student, School school)
    {
        string redColor = "#E63946";

        var admission = student.Admissions.FirstOrDefault();
        string guardianName = student.Guardians.FirstOrDefault()?.Name ?? "N/A";
        string guardianPhone = student.Guardians.FirstOrDefault()?.Phone ?? "N/A";
        string address = student.Guardians.FirstOrDefault()?.Address ?? "N/A";
        DateTimeOffset? cardValidityDate = CalculateCardValidityDate(admission?.AdmissionDate);

        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(55, 86, Unit.Millimetre);
                page.Margin(0);
                page.DefaultTextStyle(x => x.FontSize(7));

                page.Background().Image("wwwroot/images/template5_bg.png").FitWidth();

                page.Header().StopPaging().PaddingTop(7).Column(header =>
                {
                    header.Item().Row(row =>
                    {
                        row.AutoItem().Width(28).Height(28).Image("wwwroot/images/logo.png").FitArea();

                        row.RelativeItem().PaddingLeft(4).Column(col =>
                        {
                            col.Item().Text("REPL ENGLISH BOARDING SCHOOL")
                                .FontSize(9)
                                .Bold()
                                .ClampLines(1, "");
                            col.Item().Text(school.Address)
                                .FontSize(7)
                                .ClampLines(1, "");
                            col.Item().Text(school.PhonePrimary)
                                .FontSize(7)
                                .ClampLines(1, "");
                        });
                    });
                });

                page.Content().StopPaging().PaddingTop(2).Column(content =>
                {
                    content.Item().Height(25).Element(element =>
                    {
                        element
                            .PaddingTop(7)
                            .AlignCenter()
                            .Text("Identity Card")
                            .FontSize(10)
                            .Bold()
                            .FontColor(Colors.White);
                    });

                    content.Item().PaddingTop(5).PaddingLeft(25).Row(row =>
                    {
                        row.RelativeItem().AlignCenter().Column(col =>
                        {
                            col.Item().AlignCenter().Height(60).Width(60).Element(photo =>
                            {
                                if (student.Image != null)
                                {
                                    photo.Border(1)
                                        .BorderColor(Colors.Black)
                                        .Image(student.Image)
                                        .FitArea();
                                }
                                else
                                {
                                    photo.Border(1)
                                        .BorderColor(Colors.Black)
                                        .Background(Colors.Grey.Lighten3)
                                        .AlignMiddle()
                                        .AlignCenter()
                                        .Text("Photo");
                                }
                            });
                        });

                        row.AutoItem().Height(60).Width(60).Svg(GenerateQrCode(
                            $"Name: {student.FirstName} {student.LastName}, " +
                            $"Contact: {guardianPhone}, Address: {address}"
                        ));
                    });

                    content.Item().PaddingTop(2).AlignCenter().Text($"{student.FirstName} {student.LastName}")
                        .FontSize(10)
                        .Bold()
                        .FontColor(redColor)
                        .ClampLines(1, "");

                    content.Item().PaddingTop(3).PaddingLeft(20).Column(col =>
                    {
                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.ConstantColumn(5);
                                columns.RelativeColumn(10);
                            });

                            void AddRow(string label, string value)
                            {
                                table.Cell().Text(label).Bold().ClampLines(1, "");
                                table.Cell().Text(":");
                                table.Cell().Text(value).ClampLines(1, "");
                            }

                            AddRow("Class", admission?.Class.Name ?? "N/A");
                            AddRow("Roll No", admission?.RollNumber ?? "N/A");
                            AddRow("DOB", student.DateOfBirth.ToString("dd MMM yyyy"));
                            AddRow("Address", "Kathmandu, Bagmati, Nepal");
                            AddRow("Guardian", guardianName);
                            AddRow("Contact", guardianPhone);
                            AddRow("Email", student.Email ?? "N/A");
                            AddRow("Validity", cardValidityDate?.ToString("dd MMM yyyy") ?? "N/A");
                        });
                    });

                    content.Item().AlignRight().AlignBottom().Column(col =>
                    {
                        col.Item().AlignCenter().Text("Principal")
                            .FontSize(6)
                            .Bold();

                        col.Item().Width(40).Height(1)
                            .Background(Colors.Black);
                    });
                });

                page.Footer().StopPaging().Padding(3).AlignCenter().Text("If found please return to school")
                    .FontSize(7)
                    .Bold()
                    .FontColor(Colors.White)
                    .ClampLines(1, "");
            });
        }).GeneratePdf();
    }

    private byte[] GenerateTemplate6(Student student, School school)
    {
        var admission = student.Admissions.FirstOrDefault();
        string guardianName = student.Guardians.FirstOrDefault()?.Name ?? "N/A";
        string guardianPhone = student.Guardians.FirstOrDefault()?.Phone ?? "N/A";
        string address = student.Guardians.FirstOrDefault()?.Address ?? "N/A";
        DateTimeOffset? cardValidityDate = CalculateCardValidityDate(admission?.AdmissionDate);

        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(55, 86, Unit.Millimetre);
                page.Margin(0);
                page.DefaultTextStyle(x => x.FontSize(7));
                page.Background().Image("wwwroot/images/template6_bg.png").FitArea();

                page.Content().StopPaging().Column(col =>
                {
                    col.Item().PaddingTop(10).PaddingLeft(23).AlignCenter().Row(row =>
                    {
                        row.AutoItem().Width(28).Height(28)
                            .Image("wwwroot/images/logo.png").FitArea();

                        row.RelativeItem().Column(top =>
                        {
                            top.Item().Text("REPL ENGLISH BOARDING SCHOOL")
                                .FontSize(9).Bold().FontColor(Colors.Blue.Darken2).ClampLines(1, "");
                            top.Item().Text(school.Address).FontSize(6).AlignLeft().ClampLines(1, "");
                            top.Item().Text(school.PhonePrimary).FontSize(6).AlignLeft().ClampLines(1, "");
                        });
                    });

                    col.Item().PaddingTop(4).ExtendHorizontal().Background(Colors.Green.Medium)
                              .PaddingVertical(3).AlignCenter().Text("STUDENT ID CARD").FontColor(Colors.White).FontSize(9).Bold();

                    col.Item().AlignCenter().PaddingTop(2).Text($"User ID : {student.Id}")
                        .FontColor(Colors.Green.Darken2)
                        .FontSize(7);

                    col.Item().PaddingTop(4).Row(row =>
                    {
                        row.AutoItem().Width(60).Height(60).Svg(GenerateQrCode(
                            $"Name: {student.FirstName} {student.LastName}, " +
                            $"Phone: {guardianPhone}, Address: {address}"
                        ));

                        row.AutoItem().Width(60).Height(60).Element(container =>
                        {
                            if (student.Image != null)
                            {
                                container.Image(student.Image).FitArea();
                            }
                            else
                            {
                                container.Background(Colors.Grey.Lighten3)
                                         .AlignCenter().AlignMiddle()
                                         .Text("Photo")
                                         .FontSize(6);
                            }
                        });

                        row.AutoItem().AlignBottom().PaddingLeft(2).Column(signCol =>
                        {
                            signCol.Item().Text("Principal's Sign")
                                .FontSize(5)
                                .FontColor(Colors.Black)
                                .AlignCenter();

                            signCol.Item().Width(32).Height(1)
                            .Background(Colors.Black);
                        });
                    });

                    col.Item().AlignCenter().PaddingTop(4).Text($"{student.FirstName} {student.LastName}")
                        .FontSize(10).Bold().FontColor(Colors.Green.Darken2).ClampLines(1, "");

                    col.Item().PaddingLeft(23).PaddingTop(5).Table(table =>
                    {
                        table.ColumnsDefinition(cols =>
                        {
                            cols.RelativeColumn(3);
                            cols.ConstantColumn(6);
                            cols.RelativeColumn(6);
                        });

                        void Row(string label, string value, string color)
                        {
                            table.Cell().Text(label).FontColor(color).Bold().ClampLines(1, "");
                            table.Cell().Text(":");
                            table.Cell().Text(value).ClampLines(1, "");
                        }

                        Row("Class", admission?.Class.Name ?? "N/A", Colors.Blue.Darken2);
                        Row("Roll No", admission?.RollNumber ?? "N/A", Colors.Blue.Darken2);
                        Row("DOB", student.DateOfBirth.ToString("dd MMM yyyy"), Colors.Blue.Darken2);
                        Row("Guardian", guardianName, Colors.Blue.Darken2);
                        Row("Contact", guardianPhone, Colors.Blue.Darken2);
                        Row("Address", "Kathmandu, Bagmati, Nepal", Colors.Blue.Darken2);
                        Row("Validity", cardValidityDate?.ToString("yyyy-MM-dd") ?? "N/A", Colors.Blue.Darken2);
                    });
                });
            });
        }).GeneratePdf();
    }

    private byte[] GenerateTemplate7(Student student, School school)
    {
        string tealColor = "#00A5B5";
        string blueColor = "#2B82C9";

        var admission = student.Admissions.FirstOrDefault();
        string guardianName = student.Guardians.FirstOrDefault()?.Name ?? "N/A";
        string guardianPhone = student.Guardians.FirstOrDefault()?.Phone ?? "N/A";
        string address = student.Guardians.FirstOrDefault()?.Address ?? "N/A";
        DateTimeOffset? cardValidityDate = CalculateCardValidityDate(admission?.AdmissionDate);

        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(55, 86, Unit.Millimetre);
                page.Margin(0);
                page.DefaultTextStyle(x => x.FontSize(7));

                page.Header().StopPaging().Column(headerCol =>
                {
                    headerCol.Item().Background(blueColor).Row(row =>
                    {
                        row.AutoItem().Height(35).Width(35).PaddingLeft(4).Image("wwwroot/images/logo.png").FitArea();

                        row.RelativeItem().AlignMiddle().Column(column =>
                        {
                            column.Item().Text("REPL ENGLISH BOARDING SCHOOL")
                                .FontSize(9)
                                .Bold()
                                .FontColor(Colors.White)
                                .AlignCenter()
                                .ClampLines(2, "");

                            column.Item().Text(school.Address)
                                .FontSize(8)
                                .FontColor(Colors.White)
                                .AlignCenter()
                                .ClampLines(1, "");
                        });
                    });
                });

                page.Content()
                    .PaddingHorizontal(10)
                    .PaddingVertical(3)
                    .StopPaging()
                    .Column(col =>
                    {
                        col.Item().AlignCenter().Background(blueColor).Padding(2).Element(container =>
                        {
                            container.AlignCenter().Text("STUDENT ID CARD")
                                .FontSize(8)
                                .Bold()
                                .FontColor(Colors.White);
                        });

                        col.Item().AlignCenter().Padding(2).PaddingTop(5).Row(row =>
                        {
                            row.AutoItem().AlignMiddle().Element(container =>
                            {
                                if (student.Image != null)
                                {
                                    container.Width(65).Height(65)
                                        .AlignCenter()
                                        .Border(2)
                                        .BorderColor(Colors.White)
                                        .Image(student.Image)
                                        .FitArea();
                                }
                                else
                                {
                                    container.Width(65).Height(65)
                                        .Border(2)
                                        .BorderColor(Colors.White)
                                        .Background(Colors.Grey.Lighten3)
                                        .AlignMiddle()
                                        .AlignCenter()
                                        .Text("Photo");
                                }
                            });

                            row.AutoItem().AlignMiddle().Width(65).Height(65).Svg(GenerateQrCode(
                                $"Name: {student.FirstName ?? "N/A"} {student.LastName ?? "N/A"}, " +
                                $"Phone: {student.Guardians.FirstOrDefault()?.Phone ?? "N/A"}, " +
                                $"Address: {student.Guardians.FirstOrDefault()?.Address ?? "N/A"}"
                            ));
                        });

                        col.Item().AlignCenter().Row(row =>
                        {
                            row.RelativeItem().AlignMiddle().Height(1).Background(tealColor);
                            row.ConstantItem(100).AlignCenter().Text(student.FirstName + " " + student.LastName)
                            .FontSize(9).Bold().FontColor(Colors.Black).ClampLines(1, "");
                            row.RelativeItem().AlignMiddle().Height(1).Background(tealColor);
                        });

                        col.Item().PaddingVertical(4).PaddingLeft(20).AlignCenter().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(1);
                                columns.ConstantColumn(5);
                                columns.RelativeColumn(2);
                            });

                            void AddRow(string label, string value)
                            {
                                table.Cell().Text(label).Bold().ClampLines(1, "");
                                table.Cell().Text(":");
                                table.Cell().Text(value).ClampLines(2, "");
                            }

                            AddRow("Class", admission?.Class.Name ?? "N/A");
                            AddRow("Phone", guardianPhone ?? "N/A");
                            AddRow("DOB", student.DateOfBirth.ToString("yyyy-MM-dd") ?? "N/A");
                            AddRow("Address", "Dadhikot, Bhaktapur, Nepal");
                            AddRow("Guardian", guardianName ?? "N/A");
                            AddRow("Validity", cardValidityDate?.ToString("yyyy-MM-dd") ?? "N/A");
                        });

                        col.Item().AlignRight().Width(45).Height(10).Column(column =>
                        {
                            column.Item().Text("Principal's Sign")
                                .FontSize(5)
                                .FontColor(Colors.Black)
                                .AlignCenter();

                            column.Item().Height(1)
                                .Background(Colors.Black);
                        });
                    });

                page.Footer().StopPaging().Background(blueColor).Padding(3).AlignCenter()
                    .Text(text =>
                    {
                        text.ClampLines(1, "");
                        text.Span("OUR SCHOOL, OUR PRIDE")
                            .FontColor(Colors.White).FontSize(7).Italic();
                    });
            });
        }).GeneratePdf();
    }

    private byte[] GenerateTemplate8(Student student, School school)
    {
        string deeporangeColor = "#D84315";
        string greenColor = "#22B14C";

        var admission = student.Admissions.FirstOrDefault();
        string guardianName = student.Guardians.FirstOrDefault()?.Name ?? "N/A";
        string guardianPhone = student.Guardians.FirstOrDefault()?.Phone ?? "N/A";
        string address = student.Guardians.FirstOrDefault()?.Address ?? "N/A";
        DateTimeOffset? cardValidityDate = CalculateCardValidityDate(admission?.AdmissionDate);

        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(55, 86, Unit.Millimetre);
                page.Margin(2);
                page.DefaultTextStyle(x => x.FontSize(7));

                page.Background().Image("wwwroot/images/template2_bg.png").FitArea();

                page.Header().StopPaging().AlignCenter().AlignMiddle().Column(headerCol =>
                {
                    headerCol.Item().PaddingTop(20).Row(row =>
                    {
                        row.AutoItem().PaddingLeft(10).Width(28).Height(28)
                            .Image("wwwroot/images/template2_logo.png").FitArea();

                        row.RelativeItem().Column(column =>
                        {
                            column.Item().Text("REPL ENGLISH BOARDING SCHOOL")
                                .FontSize(8)
                                .Bold()
                                .FontColor(greenColor)
                                .ClampLines(2, "");

                            column.Item().Text(school.Address)
                               .FontSize(6)
                               .FontColor(Colors.Grey.Darken2)
                               .ClampLines(1, "");

                            column.Item().Text(school.PhonePrimary)
                                .FontSize(6)
                                .FontColor(Colors.Grey.Darken2)
                                .ClampLines(1, "");
                        });
                    });

                    headerCol.Item().PaddingVertical(7).AlignCenter().Text("STUDENT ID CARD")
                        .FontSize(8)
                        .Bold()
                        .FontColor(deeporangeColor);
                });

                page.Content().StopPaging().Column(col =>
                {
                    col.Item().Row(row =>
                    {
                        row.AutoItem().AlignMiddle().Width(60).Height(60)
                            .Svg(GenerateQrCode(
                                $"Name: {student.FirstName ?? "N/A"} {student.LastName ?? "N/A"}, " +
                                $"Class: {admission?.Class.Name ?? "N/A"}, " +
                                $"Guardian: {guardianName}, " +
                                $"Phone: {guardianPhone}, " +
                                $"Address: {address}"
                            ));

                        row.RelativeItem().AlignMiddle().Element(container =>
                        {
                            if (student.Image != null)
                            {
                                container.Width(60).Height(60)
                                    .Border(1)
                                    .BorderColor(Colors.Grey.Darken2)
                                    .Image(student.Image)
                                    .FitArea();
                            }
                            else
                            {
                                container.Width(60).Height(60)
                                    .Border(1)
                                    .BorderColor(Colors.Grey.Darken2)
                                    .Background(Colors.Grey.Lighten3)
                                    .AlignMiddle()
                                    .AlignCenter()
                                    .Text("Photo")
                                    .FontSize(6)
                                    .Italic()
                                    .FontColor(Colors.Grey.Darken1);
                            }
                        });

                        row.AutoItem().AlignBottom().PaddingRight(2).Width(20).Height(10).Column(column =>
                        {
                            column.Item().Text("Principal")
                                .FontSize(5)
                                .FontColor(Colors.Black)
                                .AlignCenter();

                            column.Item().AlignBottom().Height(1)
                                .Background(Colors.Black);
                        });
                    });

                    col.Item().PaddingTop(6).AlignCenter().Text($"{student.FirstName} {student.LastName}")
                        .FontSize(10)
                        .Bold()
                        .FontColor(greenColor)
                        .ClampLines(1, "");

                    col.Item().PaddingVertical(6).PaddingLeft(15).Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn(1);
                            columns.ConstantColumn(5);
                            columns.RelativeColumn(2);
                        });

                        void AddRow(string label, string value)
                        {
                            table.Cell().Text(label).Bold().ClampLines(1, "");
                            table.Cell().Text(":");
                            table.Cell().Text(value).ClampLines(2, "");
                        }

                        AddRow("Class", admission?.Class.Name ?? "N/A");
                        AddRow("DOB", student.DateOfBirth.ToString("yyyy-MM-dd") ?? "N/A");
                        AddRow("Contact", guardianPhone);
                        AddRow("Guardian", guardianName);
                        AddRow("Address", "Kathmandu, Bagmati, Nepal");
                        AddRow("Validity", cardValidityDate?.ToString("yyyy-MM-dd") ?? "N/A");
                    });
                });
            });
        }).GeneratePdf();
    }

    private byte[] GenerateTemplate9(Student student, School school)
    {
        string blueColor = "#3F48CC";
        string orangeColor = "#F8A424";
        string redColor = "#E74C3C";

        var admission = student.Admissions.FirstOrDefault();
        string guardianName = student.Guardians.FirstOrDefault()?.Name ?? "N/A";
        string guardianPhone = student.Guardians.FirstOrDefault()?.Phone ?? "N/A";
        string address = student.Guardians.FirstOrDefault()?.Address ?? "N/A";
        DateTimeOffset? cardValidityDate = CalculateCardValidityDate(admission?.AdmissionDate);


        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(55, 86, Unit.Millimetre);
                page.Margin(0);
                page.DefaultTextStyle(x => x.FontSize(7));

                page.Header().StopPaging().Column(headerCol =>
                {
                    headerCol.Item().Background(blueColor).Height(7);

                    headerCol.Item().Background(Colors.White).Padding(1).Column(column =>
                    {
                        column.Item().AlignCenter().Height(28).Width(28).Element(e =>
                        {
                            e.Image("wwwroot/images/template3_logo.png")
                              .FitHeight();
                        });

                        column.Item().Padding(2).AlignCenter().Text("REPL ENGLISH HIGHER BOARDING SCHOOL")
                            .FontSize(9)
                            .Bold()
                            .FontColor(blueColor)
                            .ClampLines(2, "");
                    });

                    headerCol.Item().Background(orangeColor).Padding(2).Element(container =>
                    {
                        container.AlignCenter().Text("STUDENT ID CARD")
                            .FontSize(7)
                            .Bold()
                            .FontColor(Colors.White);
                    });
                });

                page.Content()
                .StopPaging()
                    .PaddingHorizontal(10)
                    .PaddingTop(5)
                    .Column(col =>
                    {
                        col.Item().AlignCenter().Row(row =>
                        {
                            row.AutoItem().AlignMiddle().Element(container =>
                            {
                                if (student.Image != null)
                                {
                                    container.Width(60).Height(60)
                                        .Border(1)
                                        .BorderColor(blueColor)
                                        .Image(student.Image)
                                        .FitArea();
                                }
                                else
                                {
                                    container.Width(60).Height(60)
                                        .Border(1)
                                        .BorderColor(blueColor)
                                        .Background(Colors.Grey.Lighten3)
                                        .AlignMiddle()
                                        .AlignCenter()
                                        .Text("Photo");
                                }
                            });

                            row.AutoItem().AlignMiddle().PaddingLeft(5).Width(65).Height(65).Svg(GenerateQrCode(
                                $"Name: {student.FirstName ?? "N/A"} {student.LastName ?? "N/A"}, " +
                                $"Guardian: {guardianName}, " +
                                $"Phone: {guardianPhone}, " +
                                $"Address: {address}"
                            ));
                        });

                        col.Item().AlignCenter().PaddingTop(1).Column(column =>
                        {
                            column.Item().AlignCenter().Text("Principal Signature")
                                .FontSize(5);
                        });

                        col.Item().PaddingTop(3).AlignCenter().Text($"{student.FirstName} {student.LastName}")
                            .FontSize(9)
                            .Bold()
                            .FontColor(blueColor)
                            .ClampLines(1, "");

                        col.Item().PaddingTop(3).PaddingLeft(3).Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(1);
                                columns.ConstantColumn(5);
                                columns.RelativeColumn(2);
                            });

                            void AddRow(string label, string value)
                            {
                                table.Cell().Text(label).Bold().ClampLines(1, "");
                                table.Cell().Text(":");
                                table.Cell().Text(value).ClampLines(2, "");
                            }

                            AddRow("DOB", student.DateOfBirth.ToString("yyyy-MM-dd") ?? "N/A");
                            AddRow("Grade", admission?.Class.Name ?? "N/A");
                            AddRow("Address", "Kathmandu, Bagmati, Nepal");
                            AddRow("Contact No.", guardianPhone);
                            AddRow("Guardian", guardianName);
                        });

                        col.Item().PaddingTop(4).AlignCenter().Text($"VALID UP TO : {cardValidityDate?.ToString("yyyy-MM-dd") ?? "N/A"}")
                            .FontSize(6)
                            .Bold()
                            .FontColor(redColor)
                            .ClampLines(1, "");
                    });

                page.Footer().StopPaging().Element(footer =>
                {
                    footer.Background(blueColor)
                        .AlignCenter()
                        .Column(column =>
                        {
                            column.Item().Text(school.Address)
                                .FontSize(6)
                                .AlignCenter()
                                .FontColor(Colors.White)
                                .ClampLines(1, "");

                            column.Item().PaddingBottom(1).Text(school.PhonePrimary)
                                .FontSize(6)
                                .AlignCenter()
                                .FontColor(Colors.White)
                                .ClampLines(1, "");
                        });
                });
            });
        }).GeneratePdf();
    }

    private byte[] GenerateTemplate10(Student student, School school)
    {
        string darkBlue = "#003366";

        var admission = student.Admissions.FirstOrDefault();
        string guardianName = student.Guardians.FirstOrDefault()?.Name ?? "N/A";
        string guardianPhone = student.Guardians.FirstOrDefault()?.Phone ?? "N/A";
        string address = student.Guardians.FirstOrDefault()?.Address ?? "N/A";
        DateTimeOffset? cardValidityDate = CalculateCardValidityDate(admission?.AdmissionDate);

        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(55, 86, Unit.Millimetre);
                page.Margin(0);
                page.DefaultTextStyle(x => x.FontSize(7));

                page.Background().Image("wwwroot/images/template4_bg.png").FitWidth();

                page.Header().StopPaging().Padding(4).Column(header =>
                {
                    header.Item().AlignCenter().Row(row =>
                    {
                        row.AutoItem().PaddingLeft(5).Width(35).Height(30).Image("wwwroot/images/logo.png").FitArea();
                        row.RelativeItem().Column(col =>
                        {
                            col.Item().Text("REPL ENGLISH BOARDING SCHOOL").FontSize(9).Bold().FontColor(Colors.White).ClampLines(2, "");
                            col.Item().Text(school.Address).FontSize(7).FontColor(Colors.White).ClampLines(1, "");
                            col.Item().Text(school.PhonePrimary).FontSize(7).FontColor(Colors.White).ClampLines(1, "");
                        });
                    });

                    header.Item().PaddingTop(5).AlignCenter().Padding(2).Text("STUDENT ID CARD")
                        .FontSize(7).Bold().FontColor(Colors.White);
                });

                page.Content().StopPaging().Padding(4).PaddingLeft(10).Column(col =>
                {
                    col.Item().Row(row =>
                    {
                        row.AutoItem().Element(container =>
                        {
                            if (student.Image != null)
                            {
                                container.Width(60).Height(60)
                                    .Border(1)
                                    .BorderColor(darkBlue)
                                    .Image(student.Image)
                                    .FitArea();
                            }
                            else
                            {
                                container.Width(60).Height(60)
                                    .Border(1)
                                    .BorderColor(darkBlue)
                                    .Background(Colors.Grey.Lighten3)
                                    .AlignMiddle()
                                    .AlignCenter()
                                    .Text("Photo");
                            }
                        });

                        row.RelativeItem().PaddingLeft(6).AlignMiddle().Width(60).Height(60).Svg(GenerateQrCode(
                            $"Name: {student.FirstName} {student.LastName}, Class: {admission?.Class.Name}, Phone: {guardianPhone}, Address: {address}"
                        ));
                    });

                    col.Item().PaddingTop(2).AlignCenter().Text($"{student.FirstName} {student.LastName}")
                        .FontSize(10).Bold().FontColor(darkBlue).ClampLines(1, "");

                    col.Item().PaddingTop(3).Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn(4);
                            columns.ConstantColumn(5);
                            columns.RelativeColumn(10);
                        });

                        void AddRow(string label, string value)
                        {
                            table.Cell().Text(label).Bold().ClampLines(1, "");
                            table.Cell().Text(":");
                            table.Cell().Text(value).ClampLines(2, "");
                        }

                        AddRow("Grade", admission?.Class.Name ?? "N/A");
                        AddRow("Guardian", guardianName);
                        AddRow("Contact", guardianPhone);
                        AddRow("Email", student.Email ?? "N/A");
                        AddRow("DOB", student.DateOfBirth.ToString("dd MMM yyyy"));
                        AddRow("Address", "Kathmandu, Bagmati, Nepal");
                        AddRow("Validity", cardValidityDate?.ToString("dd MMM yyyy") ?? "N/A");
                    });

                    col.Item().PaddingTop(4).AlignCenter().Text("Principal Signature")
                        .FontSize(6).Italic();
                });

                page.Footer().StopPaging().Padding(2).AlignCenter().Text(text =>
                {
                    text.ClampLines(1, "");
                    text.Line("If found, please return to the school").FontColor(Colors.White).FontSize(6);
                });
            });
        }).GeneratePdf();
    }

    private byte[] GenerateTemplate11(Student student, School school)
    {
        string redColor = "#E63946";

        var admission = student.Admissions.FirstOrDefault();
        string guardianName = student.Guardians.FirstOrDefault()?.Name ?? "N/A";
        string guardianPhone = student.Guardians.FirstOrDefault()?.Phone ?? "N/A";
        string address = student.Guardians.FirstOrDefault()?.Address ?? "N/A";
        DateTimeOffset? cardValidityDate = CalculateCardValidityDate(admission?.AdmissionDate);

        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(55, 86, Unit.Millimetre);
                page.Margin(0);
                page.DefaultTextStyle(x => x.FontSize(7));

                page.Background().Image("wwwroot/images/template5_bg.png").FitWidth();

                page.Header().StopPaging().PaddingTop(7).Column(header =>
                {
                    header.Item().Row(row =>
                    {
                        row.AutoItem().Width(28).Height(28).Image("wwwroot/images/logo.png").FitArea();

                        row.RelativeItem().PaddingLeft(4).Column(col =>
                        {
                            col.Item().Text("REPL ENGLISH BOARDING SCHOOL")
                                .FontSize(8)
                                .Bold()
                                .ClampLines(2, "");
                            col.Item().Text(school.Address)
                                .FontSize(6)
                                .ClampLines(1, "");
                            col.Item().Text(school.PhonePrimary)
                                .FontSize(6)
                                .ClampLines(1, "");
                        });
                    });
                });

                page.Content().StopPaging().PaddingTop(2).Column(content =>
                {
                    content.Item().Height(25).Element(element =>
                    {
                        element
                            .PaddingTop(5)
                            .AlignCenter()
                            .Text("Identity Card")
                            .FontSize(10)
                            .Bold()
                            .FontColor(Colors.White);
                    });

                    content.Item().PaddingTop(5).PaddingLeft(25).Row(row =>
                    {
                        row.RelativeItem().AlignCenter().Column(col =>
                        {
                            col.Item().AlignCenter().Height(60).Width(60).Element(photo =>
                            {
                                if (student.Image != null)
                                {
                                    photo.Border(1)
                                        .BorderColor(Colors.Black)
                                        .Image(student.Image)
                                        .FitArea();
                                }
                                else
                                {
                                    photo.Border(1)
                                        .BorderColor(Colors.Black)
                                        .Background(Colors.Grey.Lighten3)
                                        .AlignMiddle()
                                        .AlignCenter()
                                        .Text("Photo");
                                }
                            });
                        });

                        row.AutoItem().Height(60).Width(60).Svg(GenerateQrCode(
                            $"Name: {student.FirstName} {student.LastName}, " +
                            $"Contact: {guardianPhone}, Address: {address}"
                        ));
                    });

                    content.Item().PaddingTop(3).AlignCenter().Text($"{student.FirstName} {student.LastName}")
                        .FontSize(10)
                        .Bold()
                        .FontColor(redColor)
                        .ClampLines(1, "");

                    content.Item().PaddingTop(3).PaddingLeft(20).Column(col =>
                    {
                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.ConstantColumn(5);
                                columns.RelativeColumn(10);
                            });

                            void AddRow(string label, string value)
                            {
                                table.Cell().Text(label).Bold().ClampLines(1, "");
                                table.Cell().Text(":");
                                table.Cell().Text(value).ClampLines(2, "");
                            }

                            AddRow("Class", admission?.Class.Name ?? "N/A");
                            AddRow("DOB", student.DateOfBirth.ToString("dd MMM yyyy"));
                            AddRow("Address", "Kathmandu, Bagmati, Nepal");
                            AddRow("Guardian", guardianName);
                            AddRow("Contact", guardianPhone);
                            AddRow("Email", student.Email ?? "N/A");
                            AddRow("Validity", cardValidityDate?.ToString("dd MMM yyyy") ?? "N/A");
                        });
                    });

                    content.Item().AlignRight().AlignBottom().Column(col =>
                    {
                        col.Item().AlignCenter().Text("Principal")
                            .FontSize(6)
                            .Bold();

                        col.Item().Width(40).Height(1)
                            .Background(Colors.Black);
                    });
                });

                page.Footer().StopPaging().Padding(3).AlignCenter().Text("If found please return to school")
                    .FontSize(7)
                    .Bold()
                    .FontColor(Colors.White)
                    .ClampLines(1, "");
            });
        }).GeneratePdf();
    }

    private byte[] GenerateTemplate12(Student student, School school)
    {
        var admission = student.Admissions.FirstOrDefault();
        string guardianName = student.Guardians.FirstOrDefault()?.Name ?? "N/A";
        string guardianPhone = student.Guardians.FirstOrDefault()?.Phone ?? "N/A";
        string address = student.Guardians.FirstOrDefault()?.Address ?? "N/A";
        DateTimeOffset? cardValidityDate = CalculateCardValidityDate(admission?.AdmissionDate);

        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(55, 86, Unit.Millimetre);
                page.Margin(0);
                page.DefaultTextStyle(x => x.FontSize(7));
                page.Background().Image("wwwroot/images/template6_bg.png").FitArea();

                page.Content().StopPaging().Column(col =>
                {
                    col.Item().PaddingTop(10).PaddingLeft(20).PaddingRight(10).AlignCenter().Row(row =>
                    {
                        row.AutoItem().Width(28).Height(28)
                            .Image("wwwroot/images/logo.png").FitArea();

                        row.RelativeItem().Column(top =>
                        {
                            top.Item().Text("REPL ENGLISH BOARDING SCHOOL")
                                .FontSize(8).Bold().FontColor(Colors.Blue.Darken2).ClampLines(2, "");
                            top.Item().Text(school.Address).FontSize(6).AlignLeft().ClampLines(1, "");
                            top.Item().Text(school.PhonePrimary).FontSize(6).AlignLeft().ClampLines(1, "");
                        });
                    });

                    col.Item().PaddingTop(4).ExtendHorizontal().Background(Colors.Green.Medium)
                              .PaddingVertical(3).AlignCenter().Text("STUDENT ID CARD").FontColor(Colors.White).FontSize(8).Bold();

                    col.Item().AlignCenter().PaddingTop(2).Text($"User ID : {student.Id}")
                        .FontColor(Colors.Green.Darken2)
                        .FontSize(7);

                    col.Item().PaddingTop(4).Row(row =>
                    {
                        row.AutoItem().Width(60).Height(60).Svg(GenerateQrCode(
                            $"Name: {student.FirstName} {student.LastName}, " +
                            $"Phone: {guardianPhone}, Address: {address}"
                        ));

                        row.AutoItem().Width(60).Height(60).Element(container =>
                        {
                            if (student.Image != null)
                            {
                                container.Image(student.Image).FitArea();
                            }
                            else
                            {
                                container.Background(Colors.Grey.Lighten3)
                                         .AlignCenter().AlignMiddle()
                                         .Text("Photo")
                                         .FontSize(6);
                            }
                        });

                        row.AutoItem().AlignBottom().PaddingLeft(2).Column(signCol =>
                        {
                            signCol.Item().Text("Principal's Sign")
                                .FontSize(5)
                                .FontColor(Colors.Black)
                                .AlignCenter();

                            signCol.Item().Width(32).Height(1)
                            .Background(Colors.Black);
                        });
                    });

                    col.Item().AlignCenter().PaddingTop(4).Text($"{student.FirstName} {student.LastName}")
                        .FontSize(10).Bold().FontColor(Colors.Green.Darken2).ClampLines(1, "");

                    col.Item().PaddingLeft(23).PaddingTop(5).Table(table =>
                    {
                        table.ColumnsDefinition(cols =>
                        {
                            cols.RelativeColumn(3);
                            cols.ConstantColumn(6);
                            cols.RelativeColumn(6);
                        });

                        void Row(string label, string value, string color)
                        {
                            table.Cell().Text(label).FontColor(color).Bold().ClampLines(1, "");
                            table.Cell().Text(":");
                            table.Cell().Text(value).ClampLines(2, "");
                        }

                        Row("Class", admission?.Class.Name ?? "N/A", Colors.Blue.Darken2);
                        Row("DOB", student.DateOfBirth.ToString("yyyy-MM-dd"), Colors.Blue.Darken2);
                        Row("Guardian", guardianName, Colors.Blue.Darken2);
                        Row("Contact", guardianPhone, Colors.Blue.Darken2);
                        Row("Address", "Kathmandu, Bagmati, Nepal", Colors.Blue.Darken2);
                        Row("Validity", cardValidityDate?.ToString("yyyy-MM-dd") ?? "N/A", Colors.Blue.Darken2);
                    });
                });
            });
        }).GeneratePdf();
    }

    public byte[] GenerateLanyardDesign(School school)
    {

        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(22.8f, 863.6f, Unit.Millimetre);
                page.MarginHorizontal(1.4f, Unit.Millimetre);
                page.MarginVertical(50.8f, Unit.Millimetre);
                page.Background().Image("wwwroot/images/lanyard-background.png").FitHeight();

                page.Header().PaddingVertical(10).PaddingHorizontal(2, Unit.Millimetre).Column(column =>
                {
                    column.Item().FlipOver().PaddingHorizontal(2).PaddingVertical(10).Height(13, Unit.Millimetre).AlignCenter().Image("wwwroot/images/logo.png").FitHeight();
                    column.Item().AlignCenter().Column(column =>
                    {
                        string schoolName = "REPL ENGLISH SCHOOL";
                        foreach (char letter in schoolName.Reverse())
                        {
                            column.Item().FlipOver().AlignCenter().Text($"{letter}")
                                .FontColor(Colors.White).FontSize(15).Bold();
                        }
                    });
                    column.Item().FlipOver().PaddingHorizontal(2).PaddingVertical(10).Height(13, Unit.Millimetre).AlignCenter().Image("wwwroot/images/logo.png").FitHeight();
                });

                page.Content().AlignCenter().AlignMiddle().PaddingVertical(10).PaddingHorizontal(2, Unit.Millimetre).Column(column =>
                {
                    column.Item().RotateRight().AlignCenter().PaddingHorizontal(2).Height(15, Unit.Millimetre).AlignCenter().Image("wwwroot/images/logo.png").FitHeight();
                    column.Item().RotateRight().AlignCenter().AlignMiddle().Text("REPL ENGLISH SCHOOL").FontColor(Colors.White).FontSize(15).Bold();
                    column.Item().RotateRight().AlignCenter().PaddingHorizontal(2).Height(15, Unit.Millimetre).AlignCenter().Image("wwwroot/images/logo.png").FitHeight();
                });

                page.Footer().PaddingVertical(10).PaddingHorizontal(2, Unit.Millimetre).Column(column =>
                {
                    column.Item().PaddingHorizontal(2).PaddingVertical(10).Height(13, Unit.Millimetre).AlignCenter().Image("wwwroot/images/logo.png").FitHeight();
                    column.Item().AlignCenter().Column(column =>
                    {
                        string schoolName = "REPL ENGLISH SCHOOL";
                        foreach (char letter in schoolName)
                        {
                            column.Item().AlignCenter().Text($"{letter}")
                                .FontColor(Colors.White).FontSize(15).Bold();
                        }
                    });
                    column.Item().PaddingHorizontal(2).PaddingVertical(10).Height(13, Unit.Millimetre).AlignCenter().Image("wwwroot/images/logo.png").FitHeight();
                });
            });
        }).GeneratePdf();
    }

    private DateTimeOffset? CalculateCardValidityDate(DateTimeOffset? admissionDate)
    {
        if (admissionDate == null)
            return null;

        return admissionDate.Value.AddYears(1);
    }

    private string GenerateQrCode(string data)
    {
        var qr = QrCode.EncodeText(data, QrCode.Ecc.Medium);
        return qr.ToSvgString(4);
    }
}