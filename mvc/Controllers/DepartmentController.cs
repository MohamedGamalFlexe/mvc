using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace mvc.Controllers
{
    public class DepartmentController : Controller
    {
        ITIContext context = new ITIContext();
        public IActionResult Index()
        {
            List<Department> departmentsList = context.Departments.Include(d => d.Emps).ToList();
            ViewData["Message"] = "Welcome to ITI";
            return View("Index", departmentsList);
        }
    }
}
