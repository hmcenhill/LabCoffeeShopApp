using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LabCoffeeShopApp.Models;
using Microsoft.AspNetCore.Http;

namespace LabCoffeeShopApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISession _session;

        public HomeController(IHttpContextAccessor httpContextAccessor)
        {
            _session = httpContextAccessor.HttpContext.Session;
        }


        public IActionResult Index()
        {
            ViewBag.Login = _session.GetString("User");
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Login = _session.GetString("User");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ViewBag.Login = _session.GetString("User");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
