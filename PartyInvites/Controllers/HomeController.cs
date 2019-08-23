using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using PartyInvites.Repository;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greating = hour > 12
                ? "Good Afteron"
                : "Good Morning";
            
            return View();
        }

        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult RsvpForm(GuestResponse response)
        {
            if (ModelState.IsValid)
            {
                MayRepository.AddResponse(response);

                return View("Thanks", response);
            }

            return View();
        }

        [HttpGet]
        public IActionResult ListResponses()
        {
            
            var willAttend = MayRepository.Responses.Where(m => m.WillAttend).ToList();
            return View(willAttend);
        }
        
    }
}