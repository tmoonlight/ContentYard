using CY_System.DomainStandard;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using Qiniu.Util;
using Qiniu.IO.Model;
using Qiniu.Common;
using Qiniu.RS;
using Qiniu.RS.Model;
using Qiniu.IO;
using Qiniu.Http;
using Qiniu.CDN;
using Qiniu.CDN.Model;
using RabbitMQ.Client;

namespace CY_System.Infrastructure
{
    /// <summary>
    /// RabbitMQ帮助类
    /// </summary>
    public class RabbitMQHelper
    {
        private string HostName
        {
            get
            {
                string str = AppConfiguration.GetValue("RabbitMQ:HostName");
                return str;
            }
        }

        private string UserName
        {
            get
            {
                string str = AppConfiguration.GetValue("RabbitMQ:UserName");
                return str;
            }
        }

        private string Password
        {
            get
            {
                string str = AppConfiguration.GetValue("RabbitMQ:Password");
                return str;
            }
        }

        /// <summary>
        /// 向RabbitMQ发送消息
        /// 普通队列：message, queue = "队列名1", isWorkQueue = false, exchange = "", exchangeType = "fanout", routingKey = "", durable = false, autoDelete = false, perfetchCount = 0
        /// 工作队列：message, queue = "队列名2", isWorkQueue = true, exchange = "", exchangeType = "fanout", routingKey = "", durable = false, autoDelete = false, perfetchCount = 0
        /// 消息持久化：message, queue = "队列名3", isWorkQueue = true, exchange = "", exchangeType = "fanout", routingKey = "", durable = true, autoDelete = false, perfetchCount = 0
        /// 发布订阅模式：message, queue = "", isWorkQueue = false, exchange = "交换机名1"--, exchangeType = "fanout", routingKey = "", durable = false, autoDelete = false, perfetchCount = 0
        /// 公平分发：perfetchCount 为1时，就是不要在同一时间给一个工作者发送多于1个的消息
        /// </summary>
        /// <param name="message">消息体</param>
        /// <param name="queue">队列名称</param>
        /// <param name="isWorkQueue">是否工作队列</param>
        /// <param name="exchange">交换机名称</param>
        /// <param name="exchangeType">交换机类型</param>
        /// <param name="routingKey">路由key</param>
        /// <param name="durable">是否持久</param>
        /// <param name="autoDelete">无消费监听时是否自动删除</param>
        /// <param name="perfetchCount">为1时，就是不要在同一时间给一个工作者发送多于1个的消息</param>
        /// <returns></returns>
        public int BasicPublish(string message, string queue = "", bool isWorkQueue = false, string exchange = "",
            string exchangeType = "fanout", string routingKey = "", bool durable = false, bool autoDelete = false,
            int perfetchCount = 0)
        {
            try
            {
                var factory = new RabbitMQ.Client.ConnectionFactory()
                {
                    HostName = this.HostName,
                    UserName = this.UserName,
                    Password = this.Password
                };

                using (var connection = factory.CreateConnection())
                {
                    using (IModel channel = connection.CreateModel())
                    {
                        if (!string.IsNullOrEmpty(exchange))
                        {
                            channel.ExchangeDeclare(exchange, //exchange 名称
                                exchangeType, //exchange 类型  fanout 订阅发布
                                durable,
                                false,
                                arguments: null);
                        }
                        //创建队列
                        if (!string.IsNullOrEmpty(queue))
                        {
                            //创建一个新的消息队列
                            channel.QueueDeclare(queue, //队列名称，为空时有系统自动分配
                                durable,
                                false,
                                autoDelete,//自动删除，如果该队列没有任何订阅的消费者的话，该队列会被自动删除。这种队列适用于临时队列。
                                arguments: null);
                        }

                        IBasicProperties properties = null;
                        //设置为工作队列
                        if (isWorkQueue)
                        {
                            properties = channel.CreateBasicProperties();
                            properties.DeliveryMode = 2;
                        }
                        //消息持久化
                        else if (durable)
                        {
                            properties = channel.CreateBasicProperties();
                            properties.SetPersistent(true);
                        }
                        //公平分发
                        if (perfetchCount != 0)
                        {
                            channel.BasicQos(0, (ushort)perfetchCount, false);
                        }
                        channel.BasicPublish(exchange, queue, basicProperties: properties, body: Encoding.UTF8.GetBytes(message));
                        Console.WriteLine(message);
                    }
                }
                return 1;
            }
            catch (Exception ex)
            {
                LoggHelper.GetInstance().LogError("RabbitMQ", "发送消息异常", ex);
                return -1;
            }
        }
    }
}
