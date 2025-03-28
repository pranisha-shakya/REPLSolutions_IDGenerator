using Net.Codecrete.QrCodeGenerator;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using REPLSolutions_IDGenerator.Models;
using REPLSolutions_IDGenerator.Services;
using SkiaSharp;

public class IdCardService : IIdCardService
{
    public byte[] GenerateIdCard(Student student, School school)
    {
        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A6.Landscape());
                page.Margin(10);
                page.DefaultTextStyle(x => x.FontSize(10));

                page.Content()
                    .Border(1)
                    .BorderColor(Colors.Grey.Medium)
                    .Padding(10)
                    .Column(col =>
                    {
                        // Header - School Name
                        col.Item().AlignCenter()
                            .Text(school.Name)
                            .Style(TextStyle.Default.Size(16).Bold().FontColor(Colors.Blue.Darken3));

                        // Student Image
                        col.Item().AlignCenter().Width(60).Height(60).Column(imageCol =>
                        {
                            if (student.Image != null)
                            {
                                imageCol.Item().Image(student.Image).FitWidth();
                            }
                            else
                            {
                                imageCol.Item().AlignCenter().AlignMiddle()
                                    .Background(Colors.Grey.Lighten3)
                                    .Height(60).Width(60)
                                    .Text("No Photo").Italic();
                            }
                        });


                        // Divider
                        col.Item().Text("––––––––––––––––––––––––––––––––––").AlignCenter();

                        // Student Information
                        col.Item().Row(row =>
                        {
                            // Student Information Column
                            row.RelativeItem(3).Column(innerCol =>
                            {
                                innerCol.Item().Text($"Name: {student.FirstName} {student.LastName}").Bold();
                                innerCol.Item().Text($"ID: {student.Id}");
                                innerCol.Item().Text($"Roll No: {student.Admissions.FirstOrDefault()?.RollNumber ?? "N/A"}");
                                innerCol.Item().Text($"Class: {student.Admissions.FirstOrDefault()?.Class.Name ?? "N/A"}");
                                innerCol.Item().Text($"DOB: {student.DateOfBirth:dd MMM yyyy}");
                                innerCol.Item().Text($"Guardian: {student.Guardians.FirstOrDefault()?.Name ?? "N/A"}");
                                innerCol.Item().Text($"Contact: {student.Guardians.FirstOrDefault()?.Phone ?? "N/A"}");
                            });

                            // QR Code Column
                            byte[] qrImage = GenerateQrCode($"ID:{student.Id}, Name:{student.FirstName} {student.LastName}");
                            if (qrImage != null)
                            {
                                row.ConstantItem(70).AlignCenter().AlignMiddle().Image(qrImage);
                            }
                        });
                    });
                page.Footer()
                .AlignCenter()
                .Text($"This ID is property of {school.Name}. If found, please return.")
                .Italic()
                .FontSize(8);
            });
        }).GeneratePdf();
    }

    private byte[] GenerateQrCode(string data)
    {
        // Generate QR code
        var qr = QrCode.EncodeText(data, QrCode.Ecc.Medium);
        int scale = 10;

        int size = qr.Size * scale;
        using var bitmap = new SKBitmap(size, size);
        using var canvas = new SKCanvas(bitmap);
        canvas.Clear(SKColors.White);
        using var paint = new SKPaint { Color = SKColors.Black };

        for (int y = 0; y < qr.Size; y++)
        {
            for (int x = 0; x < qr.Size; x++)
            {
                if (qr.GetModule(x, y))
                {
                    canvas.DrawRect(x * scale, y * scale, scale, scale, paint);
                }
            }
        }

        using var image = SKImage.FromBitmap(bitmap);
        using var dataStream = image.Encode(SKEncodedImageFormat.Png, 100);
        return dataStream.ToArray();
    }
}
