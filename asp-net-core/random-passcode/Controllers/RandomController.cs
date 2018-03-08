using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace random_passcode.Controllers {
    public class RandomController : Controller {
        public int? counter = 0;
        public string passcode;
        public int? temp;
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
            counter++;
            ViewBag.passcode = RandomString(25);
            ViewBag.counter = counter;
            return View("index");
        }
    }
}