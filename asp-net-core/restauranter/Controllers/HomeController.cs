using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using restauranter.Models;

namespace restauranter.Controllers {
    public class HomeController : Controller {
        private ReviewContext _context;

        public HomeController(ReviewContext context) {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index() {
            System.Console.WriteLine(ViewBag.maxDate);
            return View();
        }

        [HttpPost]
        [Route("postReview")]
        public IActionResult CreateReview(ReviewViewModel model) {
            if (ModelState.IsValid) {
                Review newReview = new Review {
                    Name = model.Name,
                        Restaurant = model.Restaurant,
                        ReviewText = model.ReviewText,
                        VisitDate = model.VisitDate,
                        Stars = model.Stars
                }
                _context.Add(newReview);
                _context.SaveChanges();
                return RedirectToAction("AllReviews");
            }
            return Redirect("/");
        }

        [HttpGet]
        [Route("/reviews")]
        public IActionResult AllReviews() {
            List<Review> AllReviews = _context.Reviews.OrderByDescending(review => review.VisitDate).ToList();
            ViewBag.Reviews = AllReviews;
            return View("Reviews");
        }
    }
}