using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace RunGo.WebApi.Helpers
{
    public class MessageHub : Hub
    {
        //**--------------------------基类方法重写---------------------------**//

        #region 建立连接

        public override Task OnConnected()
        {
            string clientId = Context.QueryString["ClientId"];
            string clientName = Context.QueryString["ClientName"];
            string clientType = Context.QueryString["ClientType"];

            return base.OnConnected();
        }

        #endregion

        #region 重新连接
        public override Task OnReconnected()
        {
            string tmp = Context.ConnectionId;
            return base.OnReconnected();
        }
        #endregion

        #region 断开连接

        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }

        #endregion


        //**--------------------------主业务逻辑---------------------------**//

        #region 连接测试
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task Welcome(string name)
        {
            Clients.All.listen(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ":" + name + ":" + Context.ConnectionId);
            //await Clients.Caller.welcome(name);
            await Clients.Others.welcome(name);
        }
        #endregion

    }
}