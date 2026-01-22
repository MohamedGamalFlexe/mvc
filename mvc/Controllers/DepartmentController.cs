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

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveAdd(Department dep)
        {
            if (dep.Name != null)
            {
                context.Departments.Add(dep);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Add", dep);
        }
    }
}
