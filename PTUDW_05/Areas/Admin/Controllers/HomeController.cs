﻿using Microsoft.AspNetCore.Mvc;

namespace PTUDW_05.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
