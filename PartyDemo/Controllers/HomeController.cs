using System;
using Microsoft.AspNetCore.Mvc;
using PartyDemo.Models;

namespace PartyDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.GreetingWord = DateTime.Now.Hour < 12 ? "Good morning" : "Good afternoon";
            return View("Index");
        }

        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RsvpForm(GuestResponce guestResponce)
        {
           //TODO:Complete request processing
            return View();
        }
    }
}
