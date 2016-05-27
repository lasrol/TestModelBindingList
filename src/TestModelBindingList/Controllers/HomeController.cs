using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestModelBindingList.Models;

namespace TestModelBindingList.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Message"] = "Your contact page.";
            var model = new List<CustomModel>()
            {
                new CustomModel { Question = "Your name?" },
                new CustomModel { Question = "Your Age?" },
                new CustomModel { Question = "Your Adresse?" }
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(List<CustomModel> model)
        {
            
            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
