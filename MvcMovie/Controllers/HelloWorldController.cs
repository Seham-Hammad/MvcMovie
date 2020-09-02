﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;


using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        //GET: /HelloWorld/Welcome
        public IActionResult Welcome(string name, int numTimes =1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NimRimes"] = numTimes;

            return View();
        }
    }
}