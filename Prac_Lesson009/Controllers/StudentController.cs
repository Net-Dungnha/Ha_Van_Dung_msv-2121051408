using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Prac_Lesson009.Data;
using Prac_Lesson009.Models;

namespace Prac_Lesson009.Controllers
{
    public class StudentController : Controller
    {
    private readonly AppDbContext _context;

    public StudentController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult ImportExcel()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> ImportExcel(IFormFile file)
    {
        if (file != null && file.Length > 0)
        {
            using var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            stream.Position = 0;

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using var package = new ExcelPackage(stream);
            var worksheet = package.Workbook.Worksheets.FirstOrDefault();

            if (worksheet != null && worksheet.Dimension != null)
            {
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    var name = worksheet.Cells[row, 1].Text?.Trim();
                    var email = worksheet.Cells[row, 2].Text?.Trim();
                    var studentClass = worksheet.Cells[row, 3].Text?.Trim();

                    if (string.IsNullOrWhiteSpace(name) &&
                        string.IsNullOrWhiteSpace(email) &&
                        string.IsNullOrWhiteSpace(studentClass))
                    {
                        continue;
                    }

                    var student = new Student
                    {
                        Name = name,
                        Email = email,
                        Class = studentClass
                    };

                    _context.Students.Add(student);
                }

                await _context.SaveChangesAsync();
                ViewBag.Message = "Import thành công";
            }
            else
            {
                ViewBag.Message = "Không tìm thấy sheet Excel hoặc file rỗng.";
            }
        }
        else
        {
            ViewBag.Message = "Vui lòng chọn file Excel.";
        }

        return View();
    }
}
}
