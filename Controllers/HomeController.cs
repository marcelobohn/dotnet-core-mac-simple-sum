using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstmvc.Models;

namespace firstmvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Ola()
        {
            ViewData["Message"] = "Bem vindo";

            ViewData["Primeiro"] = HttpContext.Request.Query["primeiro"].ToString();
            ViewData["Segundo"] = HttpContext.Request.Query["segundo"].ToString();
            float primeiro = ViewData["Primeiro"].Equals("") ? 0 : float.Parse(ViewData["Primeiro"].ToString());
            float segundo = ViewData["Segundo"].Equals("") ? 0 : float.Parse(ViewData["Segundo"].ToString());
            ViewData["Resultado"] = (primeiro+segundo).ToString();

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
