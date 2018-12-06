using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AoC18_core_v3.Controllers
{
    public class DaysController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Day1()
        {
            AoC18_core_v3.
            ViewData["Problem"] = "sample";
            ViewData["Solution"] = "sample2";
            return View();
        }
    }
}