using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using league.Models;
using Microsoft.AspNetCore.Mvc;

namespace league.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}