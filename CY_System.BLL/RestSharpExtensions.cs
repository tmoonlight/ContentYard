using CY_System.BLL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

//扩展restsharp
namespace RestSharp
{
    public static partial class RestClientExtensions
    {
        // 以下暂时注释,待考察,因newtonsoft json老版本不支持dynamic list
        ///// <summary>
        ///// 执行请求,结果为动态类型
        ///// </summary>
        ///// <param name="client"></param>
        ///// <param name="request"></param>
        ///// <returns></returns>
        //public static List<dynamic> ExecuteDynamicList(this IRestClient client, IRestRequest request)
        //{
        //    //newtonsoft json老版本不支持dynamic list 该方法暂时不实现
        //    request.Method = Method.GET;
        //    var response = client.Execute(request);
        //    var test = JsonConvert.DeserializeObject<List<JObject>>(response.Content);
        //    return JsonConvert.DeserializeObject<List<dynamic>>(response.Content).ToList<dynamic>();
        //}

        /// <summary>
        /// 执行请求,结果为DataTable
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(this IRestClient client, IRestRequest request)
        {
            request.Method = Method.GET;
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<DataTable>(response.Content);
        }

        /// <summary>
        /// 执行请求,结果为DataTable
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static IRestRequest AddJsonBody(this IRestRequest req, object obj)
        {
            var json = JsonConvert.SerializeObject(obj);

            return req.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
        }
    }

    /// <summary>
    /// 加入jwt的Restsharp请求
    /// </summary>
    public class SecureRestRequest : RestRequest
    {
        public SecureRestRequest()
        {
            AddJwt();
        }

        public SecureRestRequest(Method method) : base(method)
        {
            AddJwt();
        }

        public SecureRestRequest(string resource) : base(resource)
        {
            AddJwt();
        }

        public SecureRestRequest(Uri resource) : base(resource)
        {
            AddJwt();
        }

        public SecureRestRequest(string resource, Method method) : base(resource, method)
        {
            AddJwt();
        }

        public SecureRestRequest(Uri resource, Method method) : base(resource, method)
        {
            AddJwt();
        }

        private void AddJwt()
        {
            this.AddHeader("Authorization", "Bearer "+ PubClass.JwToken);
        }
    }
}
