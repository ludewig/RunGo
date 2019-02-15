using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Castle.Logging.Log4Net;
using Abp.Web;
using Abp.WebApi;
using Castle.Facilities.Logging;

namespace RunGo.Server
{
    //public class WebApiApplication : System.Web.HttpApplication
    //{
    //    protected void Application_Start()
    //    {
    //        AreaRegistration.RegisterAllAreas();
    //        GlobalConfiguration.Configure(WebApiConfig.Register);
    //        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
    //        RouteConfig.RegisterRoutes(RouteTable.Routes);
    //        BundleConfig.RegisterBundles(BundleTable.Bundles);
    //    }
    //}

    public class WebApiApplication:AbpWebApplication<StartupModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseAbpLog4Net().WithConfig(Server.MapPath("log4net.config"))
            );

            base.Application_Start(sender, e);
        }
    }
}
