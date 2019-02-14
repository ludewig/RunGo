/*-----------------------------------------------
// Copyright (C) 2018 南京戎光软件科技有限公司  版权所有。
// 文件名称：    ExceptionErrorAttribute
// 功能描述：    全局异常/错误跟踪类
// 创建标识：    panshuai 2019-02-14 15:50:22
// 修改标识：    panshuai 2019-02-14 15:50:22
// 修改描述:     
-----------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace RunGo.WebApi.Helpers
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class ExceptionErrorAttribute: ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {

            base.OnException(actionExecutedContext);
        }
    }
}