using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using bankAccount.Models;
using Microsoft.AspNetCore.Mvc;

namespace bankAccount.Controllers {
    public class LoginController : Controller {

        [HttpGet]
        [Route("/login")]
        public IActionResult Index() {
            return View();
        }
    }
}