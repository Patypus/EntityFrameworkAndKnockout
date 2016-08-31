using EntityFrameworkAndKnockout.Models.Season;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkAndKnockout.Controllers
{
    public class SeasonController : Controller
    {
        [HttpGet]
        [Authorize]
        public ActionResult ManageSeason()
        {
            //TODO - limit this to years that haven't been added yet
            //TODO - get this into a service
            var years = Enumerable.Range(1950, 100).ToList();
            var otherYears = Enumerable.Range(1950, 100).ToList();
           
            var model = new ManageSeasonViewModel
            {
                YearsWithNoCreatedSeasons = years,
                EditableSeasons = otherYears
            };
            return View(model);
        }
    }
}