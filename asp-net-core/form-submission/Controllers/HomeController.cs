using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using form_submission.Models;
using Microsoft.AspNetCore.Mvc;

namespace form_submission.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(string FirstName, string LastName, string Age, string Email, string Password) {
            User NewUser = new User {
                FirstName = FirstName,
                LastName = LastName,
                Age = Convert.ToInt32(Age),
                Email = Email,
                Password = Password
            };
            TryValidateModel(NewUser);

            if (ModelState.IsValid) {
                return View("Success");
            } else {
                ViewBag.errors = ModelState.Values;
                return View("Fail");
            }
        }
    }
}