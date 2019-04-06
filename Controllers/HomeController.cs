using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app.Models;

namespace app.Controllers
{
    public class HomeController : Controller
    {
        //[Route("{action}")]
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

        public IActionResult Photos()
        {
            throw new NotImplementedException();
        }

        public IActionResult Bio()
        {
            throw new NotImplementedException();
        }

        public IActionResult Blog()
        {
            throw new NotImplementedException();
        }

        public IActionResult Contacts()
        {
            throw new NotImplementedException();
        }
    }
}
