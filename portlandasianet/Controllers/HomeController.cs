using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using portlandasianet.Services;

namespace portlandasianet.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailSender _msgSender;

        public HomeController(IEmailSender emailSender)
        {
            _msgSender = emailSender;
        }

        public IActionResult Index()
        {
            // Before
            //AuthMessageSender msgSender = new AuthMessageSender();
            //msgSender.SendEmailAsync("david.liang@outlook.com", "test", "test");

            // After using interface
            _msgSender.SendEmailAsync("david.liang@outlook.com", "test", "test");

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

        public IActionResult Error()
        {
            return View();
        }
    }
}
