﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eTermin.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Index()
        {
            return View("GuestHomeForm");
        }
    }
}