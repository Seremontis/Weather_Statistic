﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Weather_Statistic.Models;



/// <summary>
///  Json parse require
/// </summary>
namespace Weather_Statistic.Controllers
{
    public class HomeController : Controller
    {
        private CollectData collect = new CollectData();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Searcher(int days)
        {
            ViewBag.flag = false;
            ViewBag.operation = "Town";
            ViewBag.days = days;
            return View();
        }

        [HttpGet]
        public IActionResult Town(string town,int days=2)
        {
            ViewBag.flag= true;
            ViewBag.operation = "Town";
            ViewBag.days = days;
            var models = collect.CreateList(town, days);
            return View("Searcher",models);
        }

        public IActionResult SearcherTwo(int days)
        {
            ViewBag.flag = false;
            ViewBag.days = days;
            return View();
        }

        [HttpGet]
        public IActionResult TwoTowns(string town1,string town2,int days=1)
        {
            ViewBag.flag = true;
            ViewBag.days = days;
            var models = collect.CreateList(town1, town2, days);
            
            return View("SearcherTwo", models);
        }

        public IActionResult ManyDaysCity(int days=2)
        {
            ViewBag.flag = false;
            ViewBag.days = days;
            return View();
        }

        public IActionResult ManyDaysCityResult(string town,int days)
        {
            ViewBag.flag = true;
            ViewBag.days = days;
            var models = collect.CreateList(town, days);
            return View("ManyDaysCity",models);
        }
        public IActionResult ManyDaysCompares(int days=2)
        {
            ViewBag.flag = false;
            ViewBag.days = days;
            return View();
        }

        public IActionResult ManyDaysComparesResult(string town1,string town2,int days)
        {
            ViewBag.flag = true;
            ViewBag.days = days;
            var models = collect.CreateList(town1,town2, days);
            return View("ManyDaysCompares", models);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
