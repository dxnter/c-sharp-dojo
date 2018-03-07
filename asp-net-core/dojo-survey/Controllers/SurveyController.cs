using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dojo_survey.Controllers {
    public class SurveyController : Controller {
        [HttpGet]
        [Route("")]
        public IActionResult Survey() {
            return View("index");
        }
    }
}