using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Sales Web MVC Application - C# Course.";
            ViewData["Autor"] = "Douglas Hiromi Nishiama";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Autor"] = "Douglas Hiromi Nishiama";
            ViewData["Email"] = "dnishiama@outlook.com";
            ViewData["Address1"] = "Rua 1, nº21, Jardim das palmeiras";
            ViewData["Address2"] = "São José dos Campos, SP";
            ViewData["Address3"] = "CEP 12237000";
            ViewData["Phone"] = "+55 12 91234-5678";

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
