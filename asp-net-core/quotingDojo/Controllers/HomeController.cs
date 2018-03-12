using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DbConnection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace quotingDojo.Controllers {
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
        public IActionResult Quotes() {
            DbConnector.Execute($"INSERT INTO quotes (author, quote, posted_at) VALUES ('{Request.Form["author"]}', '{Request.Form["quote"]}', {DateTime.Now})");
            return Redirect("");
        }
    }
}