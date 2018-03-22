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
            List<User> AllUsers = _context.Users.OrderByDescending(user => user.CreatedAt).ToList();
            ViewBag.Users = AllUsers;
            if (ModelState.IsValid) {
                if (_context.Users.Any(user => String.Equals(user.Name, model.Name, StringComparison.CurrentCultureIgnoreCase))) {
                    ViewBag.userExists = "A user with this name already exists";
                    return View("Accounts");
                } else {
                    User newUser = new User {
                        Name = model.Name,
                        CreatedAt = DateTime.Now
                    };
                    _context.Add(newUser);
                    _context.SaveChanges();
                    return RedirectToAction("Accounts");
                }
            }
            return View("Accounts");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id) {
            var currentUser = _context.Users.Where(user => user.UserId == id).First();
            _context.Users.Remove(currentUser);
            _context.SaveChanges();
            return RedirectToAction("Accounts");
        }
    }
}