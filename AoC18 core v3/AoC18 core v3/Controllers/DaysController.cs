using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AoC18.DayXCode;
using AoC18.Models;

namespace AoC18.Controllers
{
    public class DaysController : Controller
    {
       
        public static DayModel getModel(int daynumber)
        {
            return getModel().allDays[daynumber];
        }
        public static AllDaysModel getModel()
        {
            AllDaysModel allDays = new AllDaysModel();
            allDays.allDays = new List<DayModel>();

            allDays.allDays.Add(new DayModel(1, 2, "Chronal Calibration"));
            allDays.allDays.Add(new DayModel(2, 2, "Inventory Management System"));
            allDays.allDays.Add(new DayModel(3, 2, "No Matter How You Slice It"));
            allDays.allDays.Add(new DayModel(4, 2, "Repose Record"));
            allDays.allDays.Add(new DayModel(5, 0, "Alchemical Reduction"));
            allDays.allDays.Add(new DayModel(6, 0, "Chronal Coordinates"));
            allDays.allDays.Add(new DayModel(7, 0, "The Sum of Its Parts"));
            allDays.allDays.Add(new DayModel(8, 0, "Memory Maneuver"));
            allDays.allDays.Add(new DayModel(9, 0, "Marble Mania"));
            allDays.allDays.Add(new DayModel(10, 0, "The Stars Align"));
            allDays.allDays.Add(new DayModel(11, 0, "Chronal Charge"));
            allDays.allDays.Add(new DayModel(12, 0, "Subterranean Sustainability"));
            allDays.allDays.Add(new DayModel(13, 0, "Mine Cart Madness"));
            allDays.allDays.Add(new DayModel(14, 0, "Chocolate Charts"));
            allDays.allDays.Add(new DayModel(15, 0, "Beverage Bandits"));
            allDays.allDays.Add(new DayModel(16, 0, "Chronal Classification"));
            allDays.allDays.Add(new DayModel(17, 0, "Reservoir Research"));
            allDays.allDays.Add(new DayModel(18, 0, "Settlers of The North Pole"));
            allDays.allDays.Add(new DayModel(19, 0, "Go With The Flow"));
            allDays.allDays.Add(new DayModel(20, 0, "A Regular Map"));
            allDays.allDays.Add(new DayModel(21, 0, "Chronal Conversion"));
            allDays.allDays.Add(new DayModel(22, 0, "Mode Maze"));
            allDays.allDays.Add(new DayModel(23, 0, "Experimental Emergency Teleportation"));
            allDays.allDays.Add(new DayModel(24, 0, "Immune System Simulator 20XX"));
            allDays.allDays.Add(new DayModel(25, 0, "Four-Dimensional Adventure"));

            return allDays;
        }

        public IActionResult Index()
        {
           

            return View(getModel());
        }
        [HttpPost]
        public IActionResult Day1(string problem)
        {
            Day1Code.Day1.parse(problem);

            ViewData["Problem"] = problem;
            ViewData["Final frequency"] = Day1Code.Day1.GetFinalFrequency();
            ViewData["Duplicate frequency"] = Day1Code.Day1.GetFirstMatcihngFrequency();

            return View(getModel(0));
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
            ViewData["problem"] = problem;
            Day3Fabric.reset();
            Day3Fabric.parse(problem);
            var coords = Day3Fabric.getCalculatedDims();
            Day3Fabric.createFabric(coords.x, coords.y);
            Day3Fabric.claimAll();
            var solution =  Day3Fabric.getSolution();
            Day3Fabric.writeFabric("Day3Output.txt");
            ViewData["solution"] = solution;



            return View();
        }
        public IActionResult Day3()
        {
            ViewData["problem"] = DayXCode.Day3Claim.defaultproblem;
            ViewData["solution"] = "";
            return View("Day3");
        }
        [HttpPost]
        public IActionResult Day4(string problem)
        {
            ViewData["Title"] = "Day 4";
            ViewData["problem"] = problem;
            DayXCode.Day4.parse(problem);
            ViewData["Solution"] =  DayXCode.Day4.solvePart1();
            ViewData["Solution"] += DayXCode.Day4.solvePart2();
            return View("DayX", getModel(3));
        }
        public IActionResult Day4()
        {
            ViewData["Title"] = "Day 4";
            ViewData["ControllerTarget"] = "Day4";
            ViewData["problem"] = DayXCode.Day4.DefaultProblem;
            ViewData["Solution"] = "";
            return View("DayX", getModel(3));
        }
        public IActionResult Day5()
        {
            ViewData["problem"] = DayXCode.Day5;
            ViewData["Solution"] = "";
            return View("DayX", getModel(4));
        }
        public IActionResult Day6()
        {
            return View("placeholder", getModel(5));
        }
        public IActionResult Day7()
        {
            return View("placeholder", getModel(6));
        }
        public IActionResult Day8()
        {
            return View("placeholder", getModel(7));
        }
        public IActionResult Day9()
        {
            return View("placeholder", getModel(8));
        }

    }
}