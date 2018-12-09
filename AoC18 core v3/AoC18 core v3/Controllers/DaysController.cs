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
            Day2Code.Day2.parseProblem(problem);

            ViewData["problem"] = problem;
            ViewData["Checksum"] = Day2Code.Day2.threes * Day2Code.Day2.twos;
            ViewData["matchingChars"] = Day2Code.Day2.matchingcharacters;
            return View();
        }
        

        public IActionResult Day2()
        {
            return Day2(Day2Code.Day2.defaultproblem);
        }
        [HttpPost]
        public IActionResult Day3(String problem)
        {
            return View();
        }
        public IActionResult Day3()
        {
            return Day3(Day2Code.Day2.defaultproblem);
        }

        public IActionResult Day4()
        {
            return View("placeholder");
        }
        public IActionResult Day5()
        {
            return View("placeholder");
        }
        public IActionResult Day6()
        {
            return View("placeholder");
        }
        public IActionResult Day7()
        {
            return View("placeholder");
        }
        public IActionResult Day8()
        {
            return View("placeholder");
        }
        public IActionResult Day9()
        {
            return View("placeholder");
        }
        
    }
}