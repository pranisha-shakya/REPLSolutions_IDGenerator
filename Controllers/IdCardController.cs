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

    public IActionResult Generate(int? studentId)
    {
        if (studentId == null)
            return RedirectToAction("SelectStudent");

        var student = _context.Students.FirstOrDefault(s => s.Id == studentId);

        if (student == null)
            return NotFound("Student not found.");

        var pdfBytes = _idCardService.GenerateIdCard(student);
        var base64Pdf = Convert.ToBase64String(pdfBytes);

        var model = new IdCardViewModel
        {
            Student = student,
            PdfBase64 = base64Pdf
        };

        return View("IdCard", model);
    }


    public IActionResult Download(int studentId)
    {
        var student = _context.Students.FirstOrDefault(s => s.Id == studentId);

        if (student == null)
            return NotFound("Student not found.");

        var pdfBytes = _idCardService.GenerateIdCard(student);
        return File(pdfBytes, "application/pdf", $"Student_{studentId}_IDCard.pdf");
    }

    public IActionResult SelectStudent()
    {
        var students = _context.Students.ToList();
        return View(students);
    }
}
