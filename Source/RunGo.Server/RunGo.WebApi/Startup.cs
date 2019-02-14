using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Cors;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(RunGo.WebApi.Startup))]

namespace RunGo.WebApi
{
    /// <summary>
    /// OWIN启动类
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 应用配置
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            //实时服务SignalR配置
            app.Map("/MessageBus", map =>
            {
                //SignalR允许跨域调用
                map.UseCors(CorsOptions.AllowAll);
                HubConfiguration config = new HubConfiguration()
                {
                    //禁用JavaScript代理
                    EnableJavaScriptProxies = false,
                    //启用JSONP跨域
                    EnableJSONP = true,
                    //反馈结果给客户端
                    EnableDetailedErrors = true
                };
                map.RunSignalR(config);
            });

            //WebApi允许跨域调用
            app.UseCors(CorsOptions.AllowAll);
        }
    }
}
