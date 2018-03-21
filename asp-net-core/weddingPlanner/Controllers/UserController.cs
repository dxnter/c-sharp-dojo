using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
// my using statements
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using weddingPlanner.ActionFilters;
using weddingPlanner.Models;

namespace weddingPlanner.Controllers {
    public class UserController : Controller {
        // Entity PostGres Code First connection
        private WeddingPlannerContext _context;

        public UserController(WeddingPlannerContext context) {
            // Entity Framework connections
            _context = context;
        }
        [HttpGet]
        [Route("accounts")]
        public IActionResult Accounts() {
            return View("Accounts");
        }
    }
}