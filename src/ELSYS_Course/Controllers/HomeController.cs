using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace ELSYS_Course.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "ELSYS .NET course.";

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        
        public IActionResult Program()
        {
            return View();
        }
        
        public IActionResult Materials()
        {
            return View();
        }
        
        public IActionResult Homeworks()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
