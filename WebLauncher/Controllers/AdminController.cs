using EntityFrameworkAndKnockout.Models.Admin.AddSeason;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkAndKnockout.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        [Authorize]
        public ActionResult Dashboard()
        {
            return View();
        }
        
        [HttpGet]
        [Authorize]
        public ActionResult AddSeason()
        {
            //TODO - limit this to years that haven't been added yet
            var years = Enumerable.Range(1950, 2050).ToList();

            var model = new AddSeasonViewModel { Years = years };
            return View();
        }
    }
}