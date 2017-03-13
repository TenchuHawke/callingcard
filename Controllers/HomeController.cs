using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace callingcard.Controllers {
    public class HomeController : Controller {

        // GET: /Home/
        [HttpGet]
        [Route ("")]
        public IActionResult Submit (string firstname, string lastname, string age, string favcolor) {
            var AnonObject = new {
                FirstName = "Jeff",
                LastName = "Ravatt",
                Age = 45,
                FavColor = "Blue"
            };
            return Json (AnonObject);
         }
    }
}