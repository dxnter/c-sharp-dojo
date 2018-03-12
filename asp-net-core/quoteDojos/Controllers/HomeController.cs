using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbConnection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace quoteDojos.Controllers {
    public class HomeController : Controller {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index() {
            return View();
        }

        // POST: /quotes
        [HttpPost]
        [Route("quotes")]
        public IActionResult Quotes(string Author, string Quote) {
            DbConnector.Execute($"INSERT INTO quotes (author, quote, posted_at) VALUES ('{Author}', '{Quote}', NOW())");
            return Redirect("quotes");
        }

        // GET: /quotes
        [HttpGet]
        [Route("quotes")]
        public IActionResult Quotes() {
            List<Dictionary<string, object>> quotes = DbConnector.Query("SELECT * FROM quotes");
            ViewBag.quotes = quotes;
            return View("quotes");
        }
    }
}