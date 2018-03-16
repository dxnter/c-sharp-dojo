using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using lost_in_the_woods.Factory;
using lost_in_the_woods.Models;
using Microsoft.AspNetCore.Mvc;

namespace lost_in_the_woods.Controllers {
    public class HomeController : Controller {
        private readonly TrailFactory trailFactory;
        public HomeController() {
            trailFactory = new TrailFactory();
        }
        public IActionResult Index() {
            ViewBag.Trails = trailFactory.FindAll();
            return View();
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id) {
            trailFactory.Delete(id);
            return RedirectToAction("Index", "Home");
        }
    }
}