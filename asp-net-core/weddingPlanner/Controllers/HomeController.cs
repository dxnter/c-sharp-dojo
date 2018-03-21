using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
// my using statements
using System.Linq;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using weddingPlanner.ActionFilters;
using weddingPlanner.Factory;
using weddingPlanner.Models;

namespace weddingPlanner.Controllers {
    public class HomeController : Controller {
        // Entity PostGres Code First connection
        private WeddingPlannerContext _context;

        public HomeController(WeddingPlannerContext context) {
            // Entity Framework connections
            _context = context;
        }

        // GET: for dashboard
        [HttpGet]
        [Route("")]
        [ImportModelState]
        public IActionResult Index() {
            return View();
        }

        [HttpGet]
        [Route("orders")]
        public IActionResult Orders() {
            return View("Orders");
        }
    }
}