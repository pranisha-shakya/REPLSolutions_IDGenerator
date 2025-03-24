using QuestPDF.Fluent;
using QuestPDF.Helpers;
using REPLSolutions_IDGenerator.Models;
using REPLSolutions_IDGenerator.Services;

public class IdCardService : IIdCardService
{
    public byte[] GenerateIdCard(Student student)
    {
        return Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A6);
                page.Margin(10);
                page.DefaultTextStyle(x => x.FontSize(12));

                page.Content().Column(col =>
                {
                    col.Item().Text($"Student Name: {student.FirstName} {student.LastName}");
                    col.Item().Text($"Roll Number: {student.Admissions.FirstOrDefault()?.RollNumber ?? "N/A"}");
                    col.Item().Text($"Class: {student.Admissions.FirstOrDefault()?.Class.Name ?? "N/A"}");
                });
            });
        })
        .GeneratePdf();
    }
}
