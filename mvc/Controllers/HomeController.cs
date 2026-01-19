using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {

        public ContentResult ShowMSG()
        {
            ContentResult result = new ContentResult();
            result.Content = "Hello World2";
            return result;
        }

        //public ViewResult ShowView()
        //{
        //    ViewResult result = new ViewResult();
        //    result.ViewName = "View1";
        //    return result;
        //}

        public IActionResult View1()
        {
            return View();
        }


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

