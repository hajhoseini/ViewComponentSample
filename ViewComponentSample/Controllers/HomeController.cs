﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewComponentSample.Models;

namespace ViewComponentSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        //https://localhost:7172/home/AjaxCall اکشن زیر را می نویسیم و هرجا مدنظرمان است به آن رکوئست می دهیم.
        public IActionResult AjaxCall()
        {
            return ViewComponent("DailyMessage", new { showDefault = true, appendText = "Ajax ..." });
        }
    }
}