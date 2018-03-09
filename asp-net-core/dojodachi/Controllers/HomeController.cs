using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dojodachi.Controllers {
    public class HomeController : Controller {
        [HttpGet]
        [Route("")]
        public IActionResult Index() {
            if (HttpContext.Session.GetInt32("fullness") == null) {
                HttpContext.Session.SetInt32("fullness", 20);
                HttpContext.Session.SetInt32("happiness", 20);
                HttpContext.Session.SetInt32("meals", 3);
                HttpContext.Session.SetInt32("energy", 50);
            }
            if (HttpContext.Session.GetInt32("energy") >= 100 && HttpContext.Session.GetInt32("fullness") >= 100 && HttpContext.Session.GetInt32("happiness") >= 100) {
                TempData["Win"] = "True";
                TempData["WinMessage"] = "Congratulations! You won!";
            }
            if (HttpContext.Session.GetInt32("fullness") == 0 && HttpContext.Session.GetInt32("energy") == 0) {
                TempData["Loss"] = "True";
                TempData["lossMessage"] = "Your Dojo has passed away...";
            }
            TempData["fullness"] = HttpContext.Session.GetInt32("fullness");
            TempData["happiness"] = HttpContext.Session.GetInt32("happiness");
            TempData["meals"] = HttpContext.Session.GetInt32("meals");
            TempData["energy"] = HttpContext.Session.GetInt32("energy");
            return View();
        }

        [HttpGet]
        [Route("Feed")]
        public IActionResult Feed() {
            if ((int) HttpContext.Session.GetInt32("meals") <= 0) {
                TempData["Error"] = "No meals remaining!";
                return RedirectToAction("Index", "Home");
            } else {
                Random rnd = new Random();
                int randomAmount = rnd.Next(5, 10);
                if (randomAmount < 6) {
                    int meals = (int) HttpContext.Session.GetInt32("meals");
                    meals--;
                    HttpContext.Session.SetInt32("meals", meals);
                    TempData["Message"] = $"Your Dogo didn't like that meal → [Meals -1]";
                    return RedirectToAction("Index", "Home");
                } else {
                    int feedAmount = (int) HttpContext.Session.GetInt32("fullness");
                    int meals = (int) HttpContext.Session.GetInt32("meals");
                    meals--;
                    feedAmount = (feedAmount + randomAmount);
                    HttpContext.Session.SetInt32("meals", meals);
                    HttpContext.Session.SetInt32("fullness", feedAmount);
                    TempData["Message"] = $"You fed your Dogo → [Fullness +{randomAmount}] [Meals -1]";
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        [HttpGet]
        [Route("Play")]
        public IActionResult Play() {
            if ((int) HttpContext.Session.GetInt32("energy") < 5) {
                TempData["Error"] = "No energy remaining!";
                return RedirectToAction("Index", "Home");
            } else {
                Random rnd = new Random();
                int randomAmount = rnd.Next(5, 10);
                if (randomAmount < 6) {
                    int energy = (int) HttpContext.Session.GetInt32("energy");
                    energy -= 5;
                    HttpContext.Session.SetInt32("energy", energy);
                    TempData["Message"] = $"Your Dogo wasn't impressed → [Energy -5]";
                    return RedirectToAction("Index", "Home");
                } else {
                    int energy = (int) HttpContext.Session.GetInt32("energy");
                    int happinessAmount = (int) HttpContext.Session.GetInt32("happiness");
                    energy -= 5;
                    happinessAmount = (happinessAmount + randomAmount);
                    HttpContext.Session.SetInt32("energy", energy);
                    HttpContext.Session.SetInt32("happiness", happinessAmount);
                    TempData["Message"] = $"You played with your Dogo → [Happiness +{randomAmount}] [Energy -5]";
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        [HttpGet]
        [Route("Work")]
        public IActionResult Work() {
            if ((int) HttpContext.Session.GetInt32("energy") < 5) {
                TempData["Error"] = "No energy remaining!";
                return RedirectToAction("Index", "Home");
            } else {
                Random rnd = new Random();
                int energy = (int) HttpContext.Session.GetInt32("energy");
                int meals = (int) HttpContext.Session.GetInt32("meals");
                int mealsEarned = rnd.Next(1, 3);
                energy -= 5;
                meals = (meals + mealsEarned);
                HttpContext.Session.SetInt32("meals", meals);
                HttpContext.Session.SetInt32("energy", energy);
                TempData["Message"] = $"You worked and earned food → [Meals +{mealsEarned}] [Energy -5]";
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet]
        [Route("Sleep")]
        public IActionResult Sleep() {
            if ((int) HttpContext.Session.GetInt32("fullness") < 5) {
                TempData["Error"] = "Fullness too low!";
                return RedirectToAction("Index", "Home");
            } else if ((int) HttpContext.Session.GetInt32("happiness") < 5) {
                TempData["Error"] = "Happiness too low!";
                return RedirectToAction("Index", "Home");
            } else {
                int energy = (int) HttpContext.Session.GetInt32("energy");
                int fullness = (int) HttpContext.Session.GetInt32("fullness");
                int happiness = (int) HttpContext.Session.GetInt32("happiness");
                energy += 15;
                fullness -= 5;
                happiness -= 5;
                HttpContext.Session.SetInt32("energy", energy);
                HttpContext.Session.SetInt32("fullness", fullness);
                HttpContext.Session.SetInt32("happiness", happiness);
                TempData["Message"] = $"You slept and gained energy → [Energy +15] [Fullness -5] [Happiness -5]";
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet]
        [Route("Restart")]
        public IActionResult Restart() {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}