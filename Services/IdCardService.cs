using Net.Codecrete.QrCodeGenerator;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using REPLSolutions_IDGenerator.Models;
using REPLSolutions_IDGenerator.Services;

public class IdCardService : IIdCardService
{
    public byte[] GenerateIdCard(Student student, School school)
    {
        string tealColor = "#00A5B5";
        string blueColor = "#2B82C9";

        var admission = student.Admissions.FirstOrDefault();
        DateTimeOffset? cardValidityDate = CalculateCardValidityDate(admission?.AdmissionDate);

        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A7.Portrait());
                page.Margin(0);
                page.DefaultTextStyle(x => x.FontSize(10));

                page.Header().Column(headerCol =>
                {

                    headerCol.Item().Background(blueColor).PaddingVertical(2).Row(row =>
                    {
                        row.AutoItem().Height(35).PaddingLeft(40).Image("wwwroot/images/logo.png").FitArea();

                        row.AutoItem().AlignMiddle().Column(column =>
                        {
                            column.Item().Text(school.Name).FontSize(12).Bold().FontColor(Colors.White).AlignCenter();
                            column.Item().Text(school.Address).FontSize(8).FontColor(Colors.White).AlignCenter();
                        });
                    });
                });

                page.Content()
                    .PaddingHorizontal(10)
                    .Column(col =>
                    {
                        col.Item().AlignCenter().Padding(5).Column(photoCol =>
                        {
                            photoCol.Item().AlignCenter().Element(container =>
                            {
                                if (student.Image != null)
                                {
                                    container.Width(70).Height(70)
                                        .AlignCenter()
                                        .Border(2)
                                        .BorderColor(Colors.White)
                                        .Image(student.Image)
                                        .FitArea();
                                }
                                else
                                {
                                    container.Width(70).Height(70)
                                        .Border(2)
                                        .BorderColor(Colors.White)
                                        .Background(Colors.Grey.Lighten3)
                                        .AlignMiddle()
                                        .AlignCenter()
                                        .Text("Photo");
                                }
                            });
                        });

                        col.Item().AlignCenter().Text(student.FirstName + " " + student.LastName)
                            .FontSize(14).Bold().FontColor(Colors.Black);

                        col.Item().AlignCenter().Row(row =>
                        {
                            row.RelativeItem().AlignMiddle().Height(2).Background(tealColor);
                            row.ConstantItem(45).Padding(5).Svg(GenerateQrCode(
                                $"Name: {student.FirstName ?? "N/A"} {student.LastName ?? "N/A"}, " +
                                $"Phone: {student.Guardians.FirstOrDefault()?.Phone ?? "N/A"}, " +
                                $"Address: {student.Guardians.FirstOrDefault()?.Address ?? "N/A"}, " +
                                $"Blood Group: {"N/A"}"
                            ));
                            row.RelativeItem().AlignMiddle().Height(2).Background(tealColor);
                        });

                        col.Item().PaddingVertical(5).PaddingHorizontal(30).AlignCenter().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(6);
                                columns.ConstantColumn(12);
                                columns.RelativeColumn(6);
                            });

                            table.Cell().Text("Roll No").Bold();
                            table.Cell().Text(":").Bold();
                            table.Cell().Text(student.Admissions.FirstOrDefault()?.RollNumber ?? "N/A");

                            table.Cell().Text("Class").Bold();
                            table.Cell().Text(":").Bold();
                            table.Cell().Text(student.Admissions.FirstOrDefault()?.Class.Name ?? "N/A");

                            table.Cell().Text("Phone").Bold();
                            table.Cell().Text(":").Bold();
                            table.Cell().Text(student.Guardians.FirstOrDefault()?.Phone ?? "N/A");

                            table.Cell().Text("DOB").Bold();
                            table.Cell().Text(":").Bold();
                            table.Cell().Text(student.DateOfBirth.ToString("dd MMM yyyy") ?? "N/A");

                            table.Cell().Text("Address").Bold();
                            table.Cell().Text(":").Bold();
                            table.Cell().Text(student.Guardians.FirstOrDefault()?.Address ?? "N/A");

                            table.Cell().Text("Blood Group").Bold();
                            table.Cell().Text(":").Bold();
                            table.Cell().Text("N/A");

                            table.Cell().Text("Validity").Bold();
                            table.Cell().Text(":").Bold();
                            table.Cell().Text(cardValidityDate?.ToString("dd MMM yyyy") ?? "N/A");
                        });
                    });

                page.Footer().Background(blueColor).Padding(5).AlignCenter()
                    .Text(text =>
                    {
                        text.Span($"OUR {school.Name}, OUR PRIDE")
                            .FontColor(Colors.White).FontSize(8).Italic();
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