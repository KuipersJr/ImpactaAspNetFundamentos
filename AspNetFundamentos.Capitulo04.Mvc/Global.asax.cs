﻿using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AspNetFundamentos.Capitulo04.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BundleTable.EnableOptimizations = true;
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        //protected void Session_Start()
        //{
        //    Session.Timeout = 600;
        //}
    }
}