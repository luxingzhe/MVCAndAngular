using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using MVCAndAngular.Controllers.Core;
using MVCAndAngular.App_Start;
using System.Web.Optimization;

namespace MVCAndAngular
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //use webapi
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //load all data
            SystemController.Instance.LoadData();

            //add scripts and content bundles
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
