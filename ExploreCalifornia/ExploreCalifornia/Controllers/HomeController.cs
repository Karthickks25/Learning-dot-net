﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExploreCalifornia.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        //public string Index()
        //{
        //    return "Hello ASP NET CORE MVC!!";
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}
