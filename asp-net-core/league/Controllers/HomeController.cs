using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using league.Factory;
using league.Models;
using Microsoft.AspNetCore.Mvc;

namespace league.Controllers {
    public class HomeController : Controller {
        private readonly NinjaFactory ninjaFactory;
        public HomeController() {
            ninjaFactory = new NinjaFactory();
        }

        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        [Route("ninja/create")]
        public IActionResult Create(Ninja ninja) {
            if (ModelState.IsValid) {
                ninjaFactory.Add(ninja);
                return Redirect("/");
            } else {
                return View("Index");
            }
        }
    }

}