using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using league.Models;
using Microsoft.AspNetCore.Mvc;

namespace league.Controllers {
    public class DojoController : Controller {

        [HttpGet]
        [Route("/dojos")]
        public IActionResult Index() {
            return View("Index");
        }

        [HttpGet]
        [Route("dojo/1")]
        public IActionResult Dojo() {
            return View("Dojo");
        }
    }
}