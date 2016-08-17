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
            throw new NotImplementedException("Get on with it");
        }
    }
}