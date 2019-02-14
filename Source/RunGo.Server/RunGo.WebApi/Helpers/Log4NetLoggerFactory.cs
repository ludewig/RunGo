/*-----------------------------------------------
// Copyright (C) 2018 南京戎光软件科技有限公司  版权所有。
// 文件名称：    Log4NetLoggerFactory
// 功能描述：    
// 创建标识：    panshuai 2019-02-14 16:32:41
// 修改标识：    panshuai 2019-02-14 16:32:41
// 修改描述:     
-----------------------------------------------*/

using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using log4net.Repository;
using System.Xml;
using System.IO;
using Castle.Core.Logging;

namespace RunGo.WebApi.Helpers
{
    public class Log4NetLoggerFactory:Castle.Core.Logging.AbstractLoggerFactory
    {
        internal const string DefaultConfigFileName = "Web.config";
        private readonly ILoggerRepository _loggerRepository;

        public Log4NetLoggerFactory()
            : this(DefaultConfigFileName)
        {
        }

        public Log4NetLoggerFactory(string configFileName)
        {
            _loggerRepository = LogManager.CreateRepository(
                typeof(Log4NetLoggerFactory).Assembly,
                typeof(log4net.Repository.Hierarchy.Hierarchy)
            );

            var log4NetConfig = new XmlDocument();
            log4NetConfig.Load(File.OpenRead(System.AppDomain.CurrentDomain.BaseDirectory+configFileName));
            XmlConfigurator.Configure(_loggerRepository, log4NetConfig["log4net"]);
        }

        public Log4NetLoggerFactory(string configFileName, bool reloadOnChange)
        {
            _loggerRepository = LogManager.CreateRepository(
                typeof(Log4NetLoggerFactory).Assembly,
                typeof(log4net.Repository.Hierarchy.Hierarchy)
            );

            if (reloadOnChange)
            {
                XmlConfigurator.ConfigureAndWatch(_loggerRepository, new FileInfo(configFileName));
            }
            else
            {
                var log4NetConfig = new XmlDocument();
                log4NetConfig.Load(File.OpenRead(configFileName));
                XmlConfigurator.Configure(_loggerRepository, log4NetConfig["log4net"]);
            }
        }

        public override ILogger Create(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return new Log4NetLogger(LogManager.GetLogger(_loggerRepository.Name, name), this);
        }

        public override ILogger Create(string name, LoggerLevel level)
        {
            throw new NotSupportedException("Logger levels cannot be set at runtime. Please review your configuration file.");
        }
    }
}