using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using knight_moves_api.Models;

namespace knight_moves_api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Json("Hello World!");
        }
    }
}
