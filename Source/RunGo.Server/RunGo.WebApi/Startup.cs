using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(RunGo.WebApi.Startup))]

namespace RunGo.WebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.UseAbp();
        }
    }
}
