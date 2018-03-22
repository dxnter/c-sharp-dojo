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
    public class CoinController : Controller {
        // Entity PostGres Code First connection
        private WeddingPlannerContext _context;

        public CoinController(WeddingPlannerContext context) {
            // Entity Framework connections
            _context = context;
        }

        // GET: for dashboard
        [HttpGet]
        [Route("coins")]
        [ImportModelState]
        public IActionResult Index() {
            return View("Coins");
        }

        [HttpPost]
        [Route("newCoin")]
        public IActionResult newCoin(Coin newCoin) {
            _context.Add(newCoin);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}