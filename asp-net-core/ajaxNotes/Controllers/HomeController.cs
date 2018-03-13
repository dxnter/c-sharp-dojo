using System.Collections.Generic;
using DbConnection;
using Microsoft.AspNetCore.Mvc;

namespace ajaxNotes.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            List<Dictionary<string, object>> notes = DbConnector.Query("SELECT * FROM notes ORDER BY id DESC");
            TempData["notes"] = notes;
            return View();
        }

        [HttpPost]
        [Route("New")]
        public IActionResult New(string Title, string Note) {
            try {
                DbConnector.Execute($"INSERT INTO notes (title, note) VALUES ('{Title}', '{Note}')");
            } catch {
                TempData["invalidInput"] = "Invalid note input!";
                return Redirect("/");
            }
            return Redirect("/");
        }

        [HttpGet]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id) {
            DbConnector.Execute($"DELETE FROM notes WHERE id = {id}");
            return Redirect("/");
        }
    }
}