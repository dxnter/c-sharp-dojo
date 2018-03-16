using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using lost_in_the_woods.Factory;
using lost_in_the_woods.Models;
using Microsoft.AspNetCore.Mvc;

namespace lost_in_the_woods.Controllers {
    public class DetailController : Controller {
        private readonly TrailFactory trailFactory;
        public DetailController() {
            trailFactory = new TrailFactory();
        }

        [HttpGet]
        [Route("show/{id}")]
        public IActionResult ViewTrail(int id) {
            ViewBag.Trail = trailFactory.FindByID(id);
            return View("Detail");
        }
    }
}