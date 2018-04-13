using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CY_System.Infrastructure;
using CY_System.DomainStandard;
using CY_System.Service.Dto;
using CY_System.Service.Extensions;
using CY_System.Infrastructure.Repository;

namespace CY_System.Service.Controllers
{    
    /// <summary>
    /// {RabbitMQ}操作控制器
    /// </summary>
    [Produces("application/json")]
    [Route("api/RabbitMQ")]
    public class RabbitMQController : Controller
    {
        //RabbitMQ帮助类
        private RabbitMQHelper mRabbitMQ = new RabbitMQHelper();

        /// <summary>
        /// 向普通队列发送消息
        /// </summary>
        /// <param name="message">消息体</param>
        /// <param name="queue">队列名称</param>
        /// <returns>返回1成功，其它失败</returns>
        [HttpGet]
        [Route("BasicPublishDefault")]
        public int BasicPublishDefault(string message, string queue)
        {
            return mRabbitMQ.BasicPublish(message, queue);
        }

        /// <summary>
        /// 向工作队列发消息
        /// </summary>
        /// <param name="message">消息体</param>
        /// <param name="queue">队列名称</param>
        /// <param name="perfetchCount">为1时，就是不要在同一时间给一个工作者发送多于1个的消息(公平分发)</param>
        /// <returns>返回1成功，其它失败</returns>
        [HttpGet]
        [Route("BasicPublishWordQueue")]
        public int BasicPublishWordQueue(string message, string queue, int perfetchCount = 0)
        {
            return mRabbitMQ.BasicPublish(message, queue, true, "", "", "", false, false, perfetchCount);
        }

        /// <summary>
        /// 向持久化队列发消息
        /// </summary>
        /// <param name="message">消息体</param>
        /// <param name="queue">队列名称</param>
        /// <returns>返回1成功，其它失败</returns>
        [HttpGet]
        [Route("BasicPublishDurable")]
        public int BasicPublishDurable(string message, string queue)
        {
            return mRabbitMQ.BasicPublish(message, queue, false, "", "", "", true, false, 0);
        }

        /// <summary>
        /// 发送订阅消息
        /// </summary>
        /// <param name="message">消息体</param>
        /// <param name="exchange">交换机名称</param>
        /// <returns>返回1成功，其它失败</returns>
        [HttpGet]
        [Route("BasicPublishSubscribe")]
        public int BasicPublishSubscribe(string message, string exchange)
        {
            return mRabbitMQ.BasicPublish(message, "", false, exchange, "fanout", "", false, false, 0);
        }
    }
}
