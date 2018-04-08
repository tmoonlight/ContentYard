using System.Collections.Generic;
using System.Data;
using System.ServiceModel;
using CY_System.Domain;
using CY_System.WcfService.Interfaces;
using WXFramework.Commons;
using System;
using RestSharp;
using System.Configuration;
using CY_System.Service.Dto;

namespace CY_System.BLL.MigrateBLL
{
    /// <summary>
    /// 业务逻辑类,该段代码由代码生成器自动生成
    /// 时间：{DateTime}
    /// </summary>
    public class RabbitMQBLL
    {
        private RestClient _RabbitMQBLLServiceClient;
        private RestClient RabbitMQBLLServiceClient
        {
            get
            {
                if (_RabbitMQBLLServiceClient == null)
                {
                    //url 示例 :http://localhost:8076/api/RabbitMQ/
                    _RabbitMQBLLServiceClient = new RestClient(ConfigurationManager.AppSettings["WebApiURL"] + "RabbitMQ/");
                    _RabbitMQBLLServiceClient.Timeout = int.Parse(ConfigurationManager.AppSettings["WebApiTimeOut"]);
                }
                return _RabbitMQBLLServiceClient;
            }
        }

        /// <summary>
        /// 声明全局接口或类
        /// </summary>
        private static RabbitMQBLL _instance = new RabbitMQBLL();

        /// <summary>
        /// 外部接口获取实例
        /// </summary>
        /// <returns></returns>
        public static RabbitMQBLL GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// 向普通队列发送消息
        /// </summary>
        /// <param name="message">消息体</param>
        /// <param name="queue">队列名称</param>
        /// <returns>返回1成功，其它失败</returns>
        public int BasicPublishDefault(string message, string queue)
        {
            RestRequest req = new RestRequest("BasicPublishDefault", Method.GET);
            var res = RabbitMQBLLServiceClient.Execute<int>(req);
            req.AddParameter("message", message);
            req.AddParameter("queue", queue);
            if (res.ErrorMessage != null) throw new Exception(res.ErrorMessage);
            return res.Data;
        }

        /// <summary>
        /// 向工作队列发消息
        /// </summary>
        /// <param name="message">消息体</param>
        /// <param name="queue">队列名称</param>
        /// <param name="perfetchCount">为1时，就是不要在同一时间给一个工作者发送多于1个的消息(公平分发)</param>
        /// <returns>返回1成功，其它失败</returns>
        public int BasicPublishWordQueue(string message, string queue, int perfetchCount = 0)
        {
            RestRequest req = new RestRequest("BasicPublishWordQueue", Method.GET);
            var res = RabbitMQBLLServiceClient.Execute<int>(req);
            req.AddParameter("message", message);
            req.AddParameter("queue", queue);
            req.AddParameter("perfetchCount", perfetchCount);
            if (res.ErrorMessage != null) throw new Exception(res.ErrorMessage);
            return res.Data;
        }

        /// <summary>
        /// 向持久化队列发消息
        /// </summary>
        /// <param name="message">消息体</param>
        /// <param name="queue">队列名称</param>
        /// <returns>返回1成功，其它失败</returns>
        public int BasicPublishDurable(string message, string queue)
        {
            RestRequest req = new RestRequest("BasicPublishDurable", Method.GET);
            var res = RabbitMQBLLServiceClient.Execute<int>(req);
            req.AddParameter("message", message);
            req.AddParameter("queue", queue);
            if (res.ErrorMessage != null) throw new Exception(res.ErrorMessage);
            return res.Data;
        }

        /// <summary>
        /// 发送订阅消息
        /// </summary>
        /// <param name="message">消息体</param>
        /// <param name="exchange">队列名称</param>
        /// <returns>返回1成功，其它失败</returns>
        public int BasicPublishSubscribe(string message, string queue)
        {
            RestRequest req = new RestRequest("BasicPublishSubscribe", Method.GET);
            var res = RabbitMQBLLServiceClient.Execute<int>(req);
            req.AddParameter("message", message);
            req.AddParameter("queue", queue);
            if (res.ErrorMessage != null) throw new Exception(res.ErrorMessage);
            return res.Data;
        }
    }
}
