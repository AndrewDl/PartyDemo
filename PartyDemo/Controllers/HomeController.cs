using System;
using Microsoft.AspNetCore.Mvc;

namespace PartyDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.GreetingWord = DateTime.Now.Hour < 12 ? "Good morning" : "Good afternoon";
            return View("Index");
        }
    }
}
