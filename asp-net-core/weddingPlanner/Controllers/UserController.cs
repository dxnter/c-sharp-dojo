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
            List<User> AllUsers = _context.Users.OrderByDescending(user => user.CreatedAt).ToList();
            ViewBag.Users = AllUsers;
            return View("Accounts");
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(UserViewModel model) {
            if (ModelState.IsValid) {
                User newUser = new User {
                    Name = model.Name,
                    CreatedAt = DateTime.Now
                };
                _context.Add(newUser);
                _context.SaveChanges();
                return RedirectToAction("Accounts");
            }
            return View("Accounts");
        }
    }
}