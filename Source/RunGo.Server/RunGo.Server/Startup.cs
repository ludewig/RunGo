using System;
using System.Threading.Tasks;
using Abp.Owin;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(RunGo.Server.Startup))]

namespace RunGo.Server
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseAbp();
        }
    }
}
