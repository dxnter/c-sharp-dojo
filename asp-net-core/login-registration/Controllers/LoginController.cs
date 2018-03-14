using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DbConnection;
using login_registration.Models;
using Microsoft.AspNetCore.Mvc;

namespace login_registration.Controllers {
    public class LoginController : Controller {

        [HttpGet]
        [Route("/login")]
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login user) {
            string userAttempting = $"SELECT * FROM users WHERE Email = '{user.Email}'";
            var matchedUser = DbConnector.Query(userAttempting);
            if (matchedUser.Count > 0) {
                System.Console.WriteLine("User exists");
                return RedirectToAction("LoginSuccess");
            }
            return Redirect("/login");
        }

        [HttpGet]
        [Route("/dashboard")]
        public IActionResult LoginSuccess() {
            return View("Success");
        }
    }
}