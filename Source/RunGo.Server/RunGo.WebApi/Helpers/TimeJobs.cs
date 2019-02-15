/*-----------------------------------------------
// Copyright (C) 2018 南京戎光软件科技有限公司  版权所有。
// 文件名称：    TimeJobs
// 功能描述：    
// 创建标识：    panshuai 2019-02-14 21:38:25
// 修改标识：    panshuai 2019-02-14 21:38:25
// 修改描述:     
-----------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quartz;
using Quartz.Impl;

namespace RunGo.WebApi.Helpers
{
    /// <summary>
    /// 后台计划任务
    /// </summary>
    public class TimeJobs : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            //to do...
        }
    }

    /// <summary>
    /// 后台计划任务调度器
    /// </summary>
    public class JobScheduler
    {
        public static void Start()
        {
            //调度器工厂
            ISchedulerFactory factory = new StdSchedulerFactory();
            //调度器
            IScheduler scheduler = factory.GetScheduler();
            scheduler.GetJobGroupNames();

            /*-------------计划任务代码实现------------------*/
            ////创建任务
            //IJobDetail job = JobBuilder.Create<TimeJob>().Build();
            ////创建触发器
            //ITrigger trigger = TriggerBuilder.Create().WithIdentity("TimeTrigger", "TimeGroup").WithSimpleSchedule(t => t.WithIntervalInMinutes(10).RepeatForever()).Build();
            ////添加任务及触发器至调度器中
            //scheduler.ScheduleJob(job, trigger);
            /*-------------计划任务代码实现------------------*/

            //启动
            scheduler.Start();
        }
    }
}