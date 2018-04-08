using CY_System.DomainStandard;
using CY_System.Infrastructure;
using log4net.Appender;
using log4net.Core;
using Newtonsoft.Json.Converters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace log4net
{
    /// <summary>
    /// 自定义的log4net的appender组件
    /// 防止数据库频繁读写,设置一个队列,当容量在一定的时候则向数据库写入日志 by shz
    /// </summary>
    public class DbCacheAppender : AppenderSkeleton
    {
        #region public properties
        public string RemoteAddress { get; set; }
        /// <summary>
        /// 缓存队列长度
        /// </summary>
        public int QueueSize { get; set; }
        #endregion

        #region Public Instance Constructors
        public DbCacheAppender()
            : base()
        {
            eventQueue = new ArrayList();
        }
        #endregion

        #region private fields
        private ArrayList eventQueue;
        #endregion

        #region Override implementation of AppenderSkeleton
        protected override void Append(log4net.Core.LoggingEvent loggingEvent)
        {
            lock (eventQueue.SyncRoot)
            {
                eventQueue.Add(loggingEvent);
                //当loggername为 ":APP_STOP:" 时,立即将队列清空并且把数据写入
                if (eventQueue.Count >= QueueSize || loggingEvent.LoggerName == ":APP_STOP:")
                {
                    this.Clear();
                }
            }
        }
        #endregion

        #region Public Instance Methods

        /// <summary>
        /// Clear the list of events
        /// </summary>
        /// <remarks>
        /// Clear the list of events
        /// </remarks>
        virtual public void Clear()
        {
            lock (eventQueue.SyncRoot)
            {
                SaveToServer();
                eventQueue.Clear();
            }
        }

        /// <summary>
        /// Gets the events that have been logged.
        /// </summary>
        /// <returns>The events that have been logged</returns>
        /// <remarks>
        /// <para>
        /// Gets the events that have been logged.
        /// </para>
        /// </remarks>
        virtual public LoggingEvent[] GetEvents()
        {
            lock (eventQueue.SyncRoot)
            {
                return (LoggingEvent[])eventQueue.ToArray(typeof(LoggingEvent));
            }
        }

        #endregion Public Instance Methods

        #region private methods
        /// <summary>
        /// 推送队列中所有的日志到数据库
        /// </summary>
        private void SaveToServer()
        {
            lock (eventQueue.SyncRoot)
            {
                List<LogModel> logList = new List<LogModel>();
                foreach (log4net.Core.LoggingEvent evt in eventQueue)
                {
                    try
                    {
                        var logObj = new LogModel
                        {
                            Date = evt.TimeStamp,
                            Thread = evt.ThreadName,
                            Level = evt.Level.Name,
                            Exception = evt.ExceptionObject == null ? "" : evt.ExceptionObject.Message ?? "" + evt.ExceptionObject.StackTrace ?? "",
                            Message = evt.RenderedMessage,
                            Logger = evt.LoggerName ?? ""
                        };


                        logList.Add(logObj);
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.ToString());
                        continue;
                    }
                }
                InsertAllLog(logList);
            }
        }

        //逐条插入list,仅支持sqlserver(待改进成dapper版本,以列表形式插入性能更佳)
        private bool ExecuteNonQuery(string commandStr, List<SqlParameter> paramList)
        {
            bool result = false;
            using (SqlConnection conn = ConnectionFactory.CreateConnection(CY_SystemConsts.ConnectionString_connLog) as SqlConnection)
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                using (SqlCommand command = new SqlCommand(commandStr, conn))
                {
                    command.Parameters.AddRange(paramList.ToArray());
                    int count = command.ExecuteNonQuery();
                    result = count > 0;
                    //throw new Exception("s");
                }
            }
            return result;
        }

        /// <summary>
        /// 往数据库插入一条日志
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        public bool InsertAllLog(List<LogModel> loglist)
        {
            string command = $@"INSERT INTO WebLog_Msg([Date],[Thread],[Level],[Logger],[Message],[Exception]) VALUES (@log_date, @thread, @log_level, @logger, @message, @exception)";

            //SqlBulkCopy sqlBulkCopy = new SqlBulkCopy("server=192.168.4.223;database=UFDATA_006_2015;User ID=cyyz;Password=cyyz7201;Connect Timeout=15;");
            //sqlBulkCopy.WriteToServer()
            foreach (var log in loglist)
            {
                List<SqlParameter> paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@log_date", log.Date));
                paramList.Add(new SqlParameter("@thread", log.Thread));
                paramList.Add(new SqlParameter("@log_level", log.Level));
                paramList.Add(new SqlParameter("@logger", log.Logger));
                paramList.Add(new SqlParameter("@Message", log.Message));
                paramList.Add(new SqlParameter("@exception", log.Exception));
                ExecuteNonQuery(command, paramList);
            }
            return true;
        }
        #endregion
    }

    public class LogModel
    {
        public DateTime Date { get; set; }
        public string Thread { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
    }
}
