using ServerFacades.Database;
using ServerFacades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace EntityFrameworkAndKnockout
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            //using (var context = new Context())
            //{
            //    var d = new Driver { Name = "Bob" };
            //    context.Drivers.Add(d);
            //    context.SaveChanges();
            //}
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
