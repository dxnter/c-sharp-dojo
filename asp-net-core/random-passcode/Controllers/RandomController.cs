using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace random_passcode.Controllers {
    public class RandomController : Controller {
        public string passcode;
        public int? counter;
        private static Random random = new Random();
        public static string RandomString(int length) {
            const string chars = "ABCDEFGHOJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index() {
            return View("index");
        }

        [HttpPost]
        [Route("/generate")]
        public IActionResult Generate() {
            if (HttpContext.Session.GetInt32("counter") == null) {
                HttpContext.Session.SetInt32("counter", 1);
                int? counter = HttpContext.Session.GetInt32("counter");
                ViewBag.passcode = RandomString(14);
                ViewBag.counter = counter;
                return View("index");
            } else {
                int? counter = HttpContext.Session.GetInt32("counter");
                ViewBag.passcode = RandomString(14);
                counter++;
                HttpContext.Session.SetInt32("counter", (int) counter);
                ViewBag.counter = counter;
                return View("index");
            }
        }
    }
}