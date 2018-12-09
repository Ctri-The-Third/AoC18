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
        [HttpPost]
        public IActionResult Day1(string problem)
        {
            Day1Code.Day1.parse(problem);
            
            ViewData["Problem"] = problem;
            ViewData["Final frequency"] = Day1Code.Day1.GetFinalFrequency();
            ViewData["Duplicate frequency"] = Day1Code.Day1.GetFirstMatcihngFrequency();

            return View();
        }
        public IActionResult Day1()
        {
            //Day1Code.Day1.parse(ViewData["Problem"]);
            var problem = Day1Code.Day1.defaultproblem;
            ViewData["Problem"] = problem;
            ViewData["Final frequency"] = "Not yet calculated";
            ViewData["Duplicate frequency"] = "Not yet calculated";
            return View();
        }

        [HttpPost]
        public IActionResult Day2(String problem)
        {
            var Checksum = "Not yet calculated!";

            ViewData["problem"] = problem;
            ViewData["Checksum"] = Checksum;
            return View();
        }
        public IActionResult Day2()
        {
            return Day2(Day2Code.Day2.defaultproblem);
        }
    }
}