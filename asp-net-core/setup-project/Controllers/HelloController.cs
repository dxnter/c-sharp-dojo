using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace setup_project.Controllers {
    public class HelloController : Controller {
        [HttpGet]
        [Route("displayint")]
        public JsonResult DisplayInt() {
            var AnonObject = new {
                FirstName = "Raz",
                LastName = "Aquato",
                Age = 10
            };
            return Json(AnonObject);
        }
    }
}