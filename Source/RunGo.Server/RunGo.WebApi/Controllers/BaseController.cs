using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace RunGo.WebApi.Controllers
{
    /// <summary>
    /// WebAPI公共基类
    /// </summary>
    public class BaseApiController<T>:System.Web.Http.ApiController where T:Microsoft.AspNet.SignalR.Hub
    {
        /// <summary>
        /// 日志服务
        /// </summary>
        protected Castle.Core.Logging.ILogger Logger { get; private set; }
        
        /// <summary>
        /// SignalR客户端
        /// </summary>
        protected IHubConnectionContext<dynamic> Clients { get; private set; }
        
        /// <summary>
        /// SignalR用户组
        /// </summary>
        protected IGroupManager Groups { get; private set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        protected BaseApiController()
        {
            //log4net.ILog log = log4net.LogManager.GetCurrentLoggers()[0];
            //Logger = new Helpers.Log4NetLogger(log,new Helpers.Log4NetLoggerFactory());
            Logger = Castle.Core.Logging.NullLogger.Instance;

            var context = GlobalHost.ConnectionManager.GetHubContext<T>();
            Clients = context.Clients;
            Groups = context.Groups;
        }
    }

    /// <summary>
    /// MVC公共基类
    /// </summary>
    public class BaseMvcController<T>:System.Web.Mvc.Controller where T:Microsoft.AspNet.SignalR.Hub
    {
        /// <summary>
        /// 日志服务
        /// </summary>
        protected Castle.Core.Logging.ILogger Logger { get; private set; }

        /// <summary>
        /// SignalR客户端
        /// </summary>
        protected IHubConnectionContext<dynamic> Clients { get; private set; }

        /// <summary>
        /// SignalR用户组
        /// </summary>
        protected IGroupManager Groups { get; private set; }


        /// <summary>
        /// 构造函数
        /// </summary>
        protected BaseMvcController()
        {
            Logger = Castle.Core.Logging.NullLogger.Instance;

            var context = GlobalHost.ConnectionManager.GetHubContext<T>();
            Clients = context.Clients;
            Groups = context.Groups;

        }

    }
}