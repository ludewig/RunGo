/*-----------------------------------------------
// Copyright (C) 2018 南京戎光软件科技有限公司  版权所有。
// 文件名称：    LogFilterAttribute
// 功能描述：    
// 创建标识：    panshuai 2019-02-14 15:55:18
// 修改标识：    panshuai 2019-02-14 15:55:18
// 修改描述:     
-----------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace RunGo.WebApi.Helpers
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method,AllowMultiple =false)]
    public class LogFilterAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            //var trace = GlobalConfiguration.Configuration.Services.GetTraceWriter();
            
            base.OnActionExecuting(actionContext);
        }
    }
}