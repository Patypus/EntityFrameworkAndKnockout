using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkAndKnockout.Controllers
{
    public class TeamsController : Controller
    {
        [AllowAnonymous]
        public ActionResult List()
        {
            return View();
        }

        
    }
}