/*-----------------------------------------------
// Copyright (C) 2018 南京戎光软件科技有限公司  版权所有。
// 文件名称：    Log4NetLogger
// 功能描述：    
// 创建标识：    panshuai 2019-02-14 16:09:45
// 修改标识：    panshuai 2019-02-14 16:09:45
// 修改描述:     
-----------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.Core.Logging;
using System.Web.Http.Tracing;
using System.Net.Http;
using log4net;
using log4net.Util;
using System.Globalization;

namespace RunGo.WebApi.Helpers
{
    public class Log4NetLogger : Castle.Core.Logging.ILogger,ITraceWriter
    {
        protected internal Log4NetLoggerFactory Factory { get; set; }
        protected internal log4net.Core.ILogger Logger { get; set; }
        private static readonly Type DeclaringType = typeof(Log4NetLogger);

        public Log4NetLogger(log4net.Core.ILogger logger, Log4NetLoggerFactory factory)
        {
            Logger = logger;
            Factory = factory;
        }

        internal Log4NetLogger()
        {
        }

        internal Log4NetLogger(ILog log, Log4NetLoggerFactory factory)
            : this(log.Logger, factory)
        {
        }
        public bool IsDebugEnabled
        {
            get
            {
                return Logger.IsEnabledFor(log4net.Core.Level.Debug);
            }
        }

        public bool IsErrorEnabled
        {
            get
            {
                return Logger.IsEnabledFor(log4net.Core.Level.Error);
            }
        }

        public bool IsFatalEnabled
        {
            get
            {
                return Logger.IsEnabledFor(log4net.Core.Level.Fatal);
            }
        }

        public bool IsInfoEnabled
        {
            get
            {
                return Logger.IsEnabledFor(log4net.Core.Level.Info);
            }
        }

        public bool IsWarnEnabled
        {
            get
            {
                return Logger.IsEnabledFor(log4net.Core.Level.Warn);
            }
        }

        public virtual global::Castle.Core.Logging.ILogger CreateChildLogger(string name)
        {
            return Factory.Create(Logger.Name + "." + name);
        }

        public void Debug(string message)
        {
            if (IsDebugEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Debug, message, null);
            }
        }

        public void Debug(Func<string> messageFactory)
        {
            if (IsDebugEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Debug, messageFactory.Invoke(), null);
            }
        }

        public void Debug(string message, Exception exception)
        {
            if (IsDebugEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Debug, message, exception);
            }
        }

        public void DebugFormat(string format, params Object[] args)
        {
            if (IsDebugEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Debug, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), null);
            }
        }

        public void DebugFormat(Exception exception, string format, params Object[] args)
        {
            if (IsDebugEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Debug, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), exception);
            }
        }

        public void DebugFormat(IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsDebugEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Debug, new SystemStringFormat(formatProvider, format, args), null);
            }
        }

        public void DebugFormat(Exception exception, IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsDebugEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Debug, new SystemStringFormat(formatProvider, format, args), exception);
            }
        }

        public void Error(string message)
        {
            if (IsErrorEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Error, message, null);
            }
        }

        public void Error(Func<string> messageFactory)
        {
            if (IsErrorEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Error, messageFactory.Invoke(), null);
            }
        }

        public void Error(string message, Exception exception)
        {
            if (IsErrorEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Error, message, exception);
            }
        }

        public void ErrorFormat(string format, params Object[] args)
        {
            if (IsErrorEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Error, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), null);
            }
        }

        public void ErrorFormat(Exception exception, string format, params Object[] args)
        {
            if (IsErrorEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Error, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), exception);
            }
        }

        public void ErrorFormat(IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsErrorEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Error, new SystemStringFormat(formatProvider, format, args), null);
            }
        }

        public void ErrorFormat(Exception exception, IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsErrorEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Error, new SystemStringFormat(formatProvider, format, args), exception);
            }
        }

        public void Fatal(string message)
        {
            if (IsFatalEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Fatal, message, null);
            }
        }

        public void Fatal(Func<string> messageFactory)
        {
            if (IsFatalEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Fatal, messageFactory.Invoke(), null);
            }
        }

        public void Fatal(string message, Exception exception)
        {
            if (IsFatalEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Fatal, message, exception);
            }
        }

        public void FatalFormat(string format, params Object[] args)
        {
            if (IsFatalEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Fatal, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), null);
            }
        }

        public void FatalFormat(Exception exception, string format, params Object[] args)
        {
            if (IsFatalEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Fatal, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), exception);
            }
        }

        public void FatalFormat(IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsFatalEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Fatal, new SystemStringFormat(formatProvider, format, args), null);
            }
        }

        public void FatalFormat(Exception exception, IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsFatalEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Fatal, new SystemStringFormat(formatProvider, format, args), exception);
            }
        }

        public void Info(string message)
        {
            if (IsInfoEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Info, message, null);
            }
        }

        public void Info(Func<string> messageFactory)
        {
            if (IsInfoEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Info, messageFactory.Invoke(), null);
            }
        }

        public void Info(string message, Exception exception)
        {
            if (IsInfoEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Info, message, exception);
            }
        }

        public void InfoFormat(string format, params Object[] args)
        {
            if (IsInfoEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Info, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), null);
            }
        }

        public void InfoFormat(Exception exception, string format, params Object[] args)
        {
            if (IsInfoEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Info, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), exception);
            }
        }

        public void InfoFormat(IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsInfoEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Info, new SystemStringFormat(formatProvider, format, args), null);
            }
        }

        public void InfoFormat(Exception exception, IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsInfoEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Info, new SystemStringFormat(formatProvider, format, args), exception);
            }
        }

        public void Warn(string message)
        {
            if (IsWarnEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Warn, message, null);
            }
        }

        public void Warn(Func<string> messageFactory)
        {
            if (IsWarnEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Warn, messageFactory.Invoke(), null);
            }
        }

        public void Warn(string message, Exception exception)
        {
            if (IsWarnEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Warn, message, exception);
            }
        }

        public void WarnFormat(string format, params Object[] args)
        {
            if (IsWarnEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Warn, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), null);
            }
        }

        public void WarnFormat(Exception exception, string format, params Object[] args)
        {
            if (IsWarnEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Warn, new SystemStringFormat(CultureInfo.InvariantCulture, format, args), exception);
            }
        }

        public void WarnFormat(IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsWarnEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Warn, new SystemStringFormat(formatProvider, format, args), null);
            }
        }

        public void WarnFormat(Exception exception, IFormatProvider formatProvider, string format, params Object[] args)
        {
            if (IsWarnEnabled)
            {
                Logger.Log(DeclaringType, log4net.Core.Level.Warn, new SystemStringFormat(formatProvider, format, args), exception);
            }
        }

        public void Trace(HttpRequestMessage request, string category, TraceLevel level, Action<TraceRecord> traceAction)
        {
            string message = Newtonsoft.Json.JsonConvert.SerializeObject(request);
            switch (level)
            {
                case TraceLevel.Info:
                    Info(message);
                    break;
                case TraceLevel.Fatal:
                    Fatal(message);
                    break;
                case TraceLevel.Debug:
                    Debug(message);
                    break;
                case TraceLevel.Warn:
                    Warn(message);
                    break;
                case TraceLevel.Error:
                    Error(message);
                    break;
            }
        }
    }
}