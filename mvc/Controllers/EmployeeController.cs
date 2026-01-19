using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class EmployeeController: Controller
    {
        ITIContext context = new ITIContext();
        public IActionResult Index()
        {
            List<Employee> employeesList = context.Employees.ToList();
            return View("Index", employeesList);
        }
    }
}
