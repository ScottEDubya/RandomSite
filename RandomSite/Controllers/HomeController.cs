using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomSite.Models;
using RandomSite.Core;

namespace RandomSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var reader = new JSONFileReader();
            var clothingModel = reader.ReadFile<ClothingItemModel>("TestData.json");
            return View(clothingModel);
        }

        public IActionResult Products(string id)
        {
            var reader = new JSONFileReader();
            var clothingModel = reader.ReadFile<ClothingItemModel>("TestData.json");
            return View("product", clothingModel);
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
