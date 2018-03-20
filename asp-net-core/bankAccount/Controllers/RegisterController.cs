using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using bankAccount.Models;
using Microsoft.AspNetCore.Mvc;

namespace bankAccount.Controllers {
    public class RegisterController : Controller {

        private UserContext _context;

        public RegisterController(UserContext context) {
            _context = context;
        }

        [HttpGet]
        [Route("/register")]
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        [Route("addUser")]
        public IActionResult AddUser(RegisterViewModel model) {
            if (ModelState.IsValid) {
                User newUser = new User {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    EmailAddress = model.EmailAddress,
                    Password = model.Password
                };
                _context.Add(newUser);
                _context.SaveChanges();
                return RedirectToAction("/register");
            }
            return Redirect("/");
        }
    }
}