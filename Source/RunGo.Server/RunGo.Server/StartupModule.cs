using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Modules;
using Abp.WebApi;
using Microsoft.Owin.Security;

namespace RunGo.Server
{
    [DependsOn(typeof(AbpWebApiModule))]
    public class StartupModule:AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            //IocManager.IocContainer.Register(
            //    Component
            //        .For<IAuthenticationManager>()
            //        .UsingFactoryMethod(() => HttpContext.Current.GetOwinContext().Authentication)
            //        .LifestyleTransient()
            //);

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
 }