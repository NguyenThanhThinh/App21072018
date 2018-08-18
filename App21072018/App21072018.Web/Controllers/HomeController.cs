using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App21072018.Web.Models;
using App21072018.Services.Admin;
using App21072018.Services;

namespace App21072018.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService categoryService;

        private readonly ILoggerService logger;

        public HomeController(ICategoryService categoryService,ILoggerService logger)
        {
            this.categoryService = categoryService;

            this.logger = logger;
        }

        public IActionResult Index()
        {
            var result = categoryService.GetAll();
            logger.LogInfo($"true");
            
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
