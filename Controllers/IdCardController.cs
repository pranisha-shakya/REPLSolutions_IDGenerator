using Microsoft.AspNetCore.Mvc;
using REPLSolutions_IDGenerator.Data;
using REPLSolutions_IDGenerator.Models.ViewModels;
using REPLSolutions_IDGenerator.Services;

public class IdCardController : Controller
{
    private readonly IIdCardService _idCardService;
    private readonly AppDbContext _context;

    public IdCardController(IIdCardService idCardService, AppDbContext context)
    {
        _idCardService = idCardService;
        _context = context;
    }

    public IActionResult Generate(int? studentId, string design = "default")
    {
        if (studentId == null)
            return RedirectToAction("SelectStudent");

        var student = _context.Students.FirstOrDefault(s => s.Id == studentId);
        if (student == null)
            return NotFound("Student not found.");

        var school = _context.Schools.FirstOrDefault();
        if (school == null)
            return NotFound("School information not found.");

        var cardDesign = GetCardDesign(design);

        var pdfBytes = _idCardService.GenerateIdCard(student, school, cardDesign);
        var base64Pdf = Convert.ToBase64String(pdfBytes);

        var model = new IdCardViewModel
        {
            Student = student,
            PdfBase64 = base64Pdf
        };

        return View("IdCard", model);
    }


    public IActionResult Download(int studentId, string design = "default")
    {
        var student = _context.Students.FirstOrDefault(s => s.Id == studentId);
        if (student == null)
            return NotFound("Student not found.");

        var school = _context.Schools.FirstOrDefault();
        if (school == null)
            return NotFound("School information not found.");

        var cardDesign = GetCardDesign(design);

        var pdfBytes = _idCardService.GenerateIdCard(student, school, cardDesign);
        return File(pdfBytes, "application/pdf", $"Student_{studentId}_IDCard.pdf");
    }

    public IActionResult SelectStudent()
    {
        var students = _context.Students.ToList();
        return View(students);
    }


    private IdCardService.IdCardDesign GetCardDesign(string design)
    {
        return design?.ToLower() switch
        {
            "template2" => IdCardService.IdCardDesign.Template2,
            "template3" => IdCardService.IdCardDesign.Template3,
            "template4" => IdCardService.IdCardDesign.Template4,
            "template5" => IdCardService.IdCardDesign.Template5,
            _ => IdCardService.IdCardDesign.Default
        };
    }
}
