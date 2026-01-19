using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult getAll()
        {
            StudentBL studentBL = new StudentBL();
            List<Student> students = studentBL.GetAll();
            return View(students);
        }

        public IActionResult Details(int id)
        {
            StudentBL studentBL = new StudentBL();
            Student? student = studentBL.GetById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
    }
}
