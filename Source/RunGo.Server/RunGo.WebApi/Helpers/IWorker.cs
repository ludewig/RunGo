/*-----------------------------------------------
// Copyright (C) 2018 南京戎光软件科技有限公司  版权所有。
// 文件名称：    IWorker
// 功能描述：    
// 创建标识：    panshuai 2019-02-14 22:07:07
// 修改标识：    panshuai 2019-02-14 22:07:07
// 修改描述:     
-----------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunGo.WebApi.Helpers
{
    public interface IWorker
    {
        void Publish(string message, string topic);
        void Receive(string message, string topic);
    }
}
