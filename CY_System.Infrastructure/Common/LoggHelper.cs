using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace CY_System.Infrastructure
{
    public class LoggHelper
    {
        /// <summary>
        /// 缓存最大队列长度,为0则不缓存
        /// </summary>
        private const int MAX_CACHE_QUEUE_LENGTH = 0;
        /// <summary>
        /// 声明全局接口或类
        /// </summary>
        private static LoggHelper _instance = new LoggHelper();

        private static log4net.Repository.ILoggerRepository _repo;

        /// <summary>
        /// 外部接口获取实例
        /// </summary>
        /// <returns></returns>
        public static LoggHelper GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// 启动时会自动执行一次
        /// </summary>
        private LoggHelper()
        {
            DbCacheAppender appender3 = new DbCacheAppender();
            //缓存队列最大长度
            appender3.QueueSize = MAX_CACHE_QUEUE_LENGTH;
            _repo = log4net.LogManager.CreateRepository("shao");
            //以下代码如果运行第二次会出错
            try
            {
                log4net.Config.BasicConfigurator.Configure(LoggHelper._repo, appender3);
            }
            catch
            {
                //屏蔽错误
            }
        }

        private log4net.ILog log = null;

        //INFO（一般信息）：记录系统运行中应该让用户知道的基本信息。例如，服务开始运行，功能已经开户等。
        public void LogInfo(string logger, string message, Exception exception = null)
        {
            log = log4net.LogManager.GetLogger(LoggHelper._repo.Name, logger);
            log.Info(message, exception);
        }

        //WARN（警告）：记录系统中不影响系统继续运行，但不符合系统运行正常条件，有可能引起系统错误的信息。例如，记录内容为空，数据内容不正确等。
        public void LogWarn(string logger, string message, Exception exception)
        {
            log = log4net.LogManager.GetLogger(LoggHelper._repo.Name, logger);
            log.Warn(message, exception);
        }

        //FATAL（致命错误）：记录系统中出现的能使用系统完全失去功能，服务停止，系统崩溃等使系统无法继续运行下去的错误。例如，数据库无法连接，系统出现死循环。
        public void LogFatal(string logger, string message, Exception exception)
        {
            log = log4net.LogManager.GetLogger(LoggHelper._repo.Name, logger);
            log.Fatal(message, exception);
        }

        //ERROR（一般错误）：记录系统中出现的导致系统不稳定，部分功能出现混乱或部分功能失效一类的错误。例如，数据字段为空，数据操作不可完成，操作出现异常等。
        public void LogError(string logger, string message, Exception exception)
        {
            log = log4net.LogManager.GetLogger(LoggHelper._repo.Name, logger);
            log.Error(message, exception);
        }

        //DEBUG （调试信息）：记录系统用于调试的一切信息，内容或者是一些关键数据内容的输出
        public void LogDebug(string logger, string message, Exception exception)
        {
            log = log4net.LogManager.GetLogger(LoggHelper._repo.Name, logger);
            log.Debug(message, exception);
        }
    }

}
