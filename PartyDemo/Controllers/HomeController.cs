using System;
using Microsoft.AspNetCore.Mvc;

namespace PartyDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.CurrentTime = DateTime.Now;
            return View("Index");
        }
    }
}
