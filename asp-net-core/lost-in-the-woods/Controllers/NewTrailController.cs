using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using lost_in_the_woods.Factory;
using lost_in_the_woods.Models;
using Microsoft.AspNetCore.Mvc;

namespace lost_in_the_woods.Controllers {
    public class NewTrailController : Controller {
        private readonly TrailFactory trailFactory;
        public NewTrailController() {
            trailFactory = new TrailFactory();
        }

        [HttpGet]
        [Route("new")]
        public IActionResult Index() {
            return View("NewTrail");
        }
        
        [HttpPost]
        [Route("create")]
        public IActionResult Create(Trail newTrail) {
            if (ModelState.IsValid) {
                trailFactory.Add(newTrail);
                return Redirect("/");
            } else {
                return View("NewTrail");
            }
        }
    }
}