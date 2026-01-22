using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class BindController : Controller
    {
        public IActionResult TestPrmitive(string name, int age, string[] color)
        {
            return Content($"name is {name}, and age is {age}, and colors {color}");
        }
        public IActionResult TestPrmitive2(Department dep)
        {
            return Content($"name is {dep.Name}, and ManagerName is {dep.ManagerName}");
        }
        public IActionResult TestDic(Dictionary<string, string> phones)
        {
            return Content($"ok");
        }
    }
}
