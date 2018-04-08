using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using smssdk;
using smssdkCY;

namespace CY_System.Infrastructure
{
    /// <summary>
    /// 改造后的smshelper方法,相较于原方法,注释了一些写日志的代码,后续写日志的操作请在
    /// 消费者代码处编写,或者以注入的形式配置到这个类中 by shz
    /// </summary>
    public class SMSHelper
    {
        WebServiceSoapClient sms = new WebServiceSoapClient(WebServiceSoapClient.EndpointConfiguration.WebServiceSoap);
        /// <summary>
        /// 本次发送短信返回的文本
        /// </summary>
        public string ResultText { get; private set; }
        /// <summary>
        /// 本次发送短信发回的代码
        /// </summary>
        public string CodeText { get; private set; }

        /// <summary>
        /// 注册号
        /// </summary>
        private string sn;

        /// <summary>
        /// 密码
        /// </summary>
        private string pwd;

        /// <summary>
        /// 加密密码
        /// </summary>
        private string SNPWD;

        public SMSHelper(string SmsType)
        {
            switch (SmsType)
            {
                case "XZ":
                    sn = AppConfiguration.GetValue("SN").ToString();
                    pwd = AppConfiguration.GetValue("PWD").ToString();
                    System.Security.Cryptography.MD5 md = System.Security.Cryptography.MD5.Create();
                    byte[] result = Encoding.Default.GetBytes(sn + pwd);
                    byte[] output = md.ComputeHash(result);
                    SNPWD = BitConverter.ToString(output).Replace("-", "");
                    break;
                case "CY":
                    E_SMS_URL = AppConfiguration.GetValue("E_SMS_URL");
                    Crop_NO = AppConfiguration.GetValue("Crop_NO");//"企业编号";
                    UName = AppConfiguration.GetValue("UName");//"用户名";
                    UPwd = AppConfiguration.GetValue("UPwd");//"密码";
                    break;
            }
        }

        /// <summary>
        /// 普通群发短信mt方法
        /// </summary>
        /// <param name="sn">序列号</param>
        /// <param name="SNPWD">密码要MD5(SN+PWD)加密，取32位大写</param>
        /// <param name="mobiles">手机号列表</param>
        /// <param name="content">短信内容</param>
        /// <param name="ext">扩展码</param>
        /// <param name="stime">定时时间</param>
        /// <param name="rrid">流水号</param>
        /// <returns>发送结果</returns>
        public async Task<string> Mt(string mobiles, string content, string ext, string stime, string rrid)
        {
            System.Net.ServicePointManager.Expect100Continue = false;
            string result = await sms.mtAsync(sn, SNPWD, mobiles, content, ext, stime, rrid);
            return CheckResult(result, mobiles);
        }

        /// <summary>
        /// 个性群发短信gxmt方法
        /// </summary>
        /// <param name="sn">序列号</param>
        /// <param name="SNPWD">密码要MD5(SN+PWD)加密，取32位大写</param>
        /// <param name="mobiles">手机号列表</param>
        /// <param name="content">短信内容,要经过URLgb2312编码和手机号对应好</param>
        /// <param name="ext">扩展码</param>
        /// <param name="stime">定时时间</param>
        /// <param name="rrid">流水号</param>
        /// <returns>发送结果</returns>
        public async Task<string> Gxmt(string mobiles, string content, string ext, string stime, string rrid)
        {
            System.Net.ServicePointManager.Expect100Continue = false;
            string result = await sms.gxmtAsync(sn, SNPWD, mobiles, content, ext, stime, rrid);
            return CheckResult(result, mobiles);
        }

        /// <summary>
        /// 普通群发短信mdSmsSend_u方法
        /// </summary>
        /// <param name="sn">序列号</param>
        /// <param name="SNPWD">密码要MD5(SN+PWD)加密，取32位大写</param>
        /// <param name="mobiles">手机号列表</param>
        /// <param name="content">短信内容,要经过URLutf-8编码</param>
        /// <param name="ext">扩展码</param>
        /// <param name="stime">定时时间</param>
        /// <param name="rrid">流水号</param>
        /// <returns>发送结果</returns>
        public async Task<string> MdSmsSend_u(string mobiles, string content, string ext, string stime, string rrid)
        {
            System.Net.ServicePointManager.Expect100Continue = false;
            string result =await sms.mdSmsSend_uAsync(sn, SNPWD, mobiles, content, ext, stime, rrid);
            return CheckResult(result, mobiles);
        }

        //对比
        //public string MdSmsSend_u(string mobiles, string content, string ext, string stime, string rrid)
        //{
        //    System.Net.ServicePointManager.Expect100Continue = false;
        //    string result = sms.mdSmsSend_u(sn, SNPWD, mobiles, content, ext, stime, rrid);
        //    return CheckResult(result, mobiles);
        //}

        /// <summary>
        /// 查询短信剩余条数
        /// </summary>
        /// <param name="sn">序列号</param>
        /// <param name="SNPWD">密码要MD5(SN+PWD)加密，取32位大写</param>
        /// <returns>短信剩余条数</returns>
        public async Task<string> Balance()
        {
            System.Net.ServicePointManager.Expect100Continue = false;
            string result =await sms.balanceAsync(sn, SNPWD);
            CodeText = result;
            if (result.StartsWith("-"))
            {
                ResultText = GetWhy(result);
                return "发送失败！" + ResultText + "。返回值是：" + CodeText;
            }
            return result;
        }


        /// <summary>
        /// 取回复短信
        /// </summary>
        /// <param name="sn">序列号</param>
        /// <param name="SNPWD">密码要MD5(SN+PWD)加密，取32位大写</param>
        /// <returns>回复短信</returns>
        public async Task<string> Mo()
        {
            System.Net.ServicePointManager.Expect100Continue = false;
            string result =await sms.moAsync(sn, SNPWD);
            if (result.StartsWith("-"))
            {
                return "查询失败！返回值是：" + result;
            }

            if (result.Equals("1"))
            {
                return "当前没有用户上行短信";
            }

            StringBuilder sb = new StringBuilder();
            string[] temp = result.Split('\n');
            for (int i = 0; i < temp.Length; i++)
            {
                string[] detail = temp[i].Split(',');
                sb.AppendLine("第" + (i + 1).ToString() + "条");
                //sb.AppendLine("moID:"+detail[0]);
                //sb.AppendLine("特服号:" + detail[1]);
                sb.AppendLine("手机号:" + detail[2]);
                sb.AppendLine("回复内容:" + HttpUtility.UrlDecode(detail[3], Encoding.GetEncoding("gb2312")));//回复的内容需要解码);
                sb.AppendLine("回复时间:" + detail[4]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 给序列号充值
        /// </summary>
        /// <param name="sn">序列号</param>
        /// <param name="SNPWD">密码</param>
        /// <param name="CardNo">充值卡号</param>
        /// <param name="CardPwd">充值卡密码</param>
        /// <returns>充值结果</returns>
        public async Task<string> ChargeUp(string CardNo, string CardPwd)
        {
            System.Net.ServicePointManager.Expect100Continue = false;
            string result =await sms.ChargUpAsync(sn, SNPWD, CardNo, CardPwd);
            return result;
        }
        string CheckResult(string result, string mobiles)
        {
            CodeText = result;
            if (result.StartsWith("-"))
            {
                ResultText = GetWhy(result);
                return "发送失败！" + ResultText + "。返回值是：" + CodeText;
                //SqlDataHelper_IH.WriteLoclFile("[短信] Mobiles[" + mobiles + "]发送失败：" + ResultText + "。返回值是：" + CodeText + "\r", "_SMS");
            }
            else
            {
                ResultText = "发送成功。流水号是：" + result;
                // SqlDataHelper_IH.WriteLoclFile("[短信] Mobiles[" + mobiles + "]发送成功！流水号是：" + result + "\r", "_SMS");
                return ResultText;
            }
        }

        string GetWhy(string code)
        {
            switch (code)
            {
                case "0":
                    return "发送成功";
                case "-2":
                    return "序列号未注册或加密不对";

                case "-4":
                    return "余额不足";
                case "-6":
                    return "参数错误，请检测所有参数";
                case "-7":

                    return "权限受限";

                case "-9":

                    return "扩展码权限错误";
                case "-10":

                    return "内容过长，短信不得超过500个字符";
                case "-20":

                    return "相同手机号，相同内容重复提交";
                case "-22":

                    return "Ip鉴权失败";

                default:
                    return "错误，请调试程序";
            }
        }

        #region 易信通邮件发送 配置
        private static string E_SMS_URL = string.Empty;
        private static string Crop_NO = string.Empty;//"企业编号";
        private static string UName = string.Empty;//"用户名";
        private static string UPwd = string.Empty;//"密码";

        /// <summary>
        /// 发送
        /// </summary>
        /// <param name="telephone">手机号码</param>
        /// <param name="msg">内容</param>
        /// <returns></returns>
        /*
            Sms请求参数说明：
            类别	   参数名称	类型	    说明
            输入	   In0	    string	企业编号
            输入	   In1	    string	用户名称
            输入	   In2	    string	用户密码ww
            输入	   In3	    string	短信内容, 最大402个字或字符，短信发送必须按照短信模板，否则就会报模板不符，短信模板说明见3.1.1。
            输入	   In4	    string	手机号码(多个号码用”,”分隔)，最多1000个号码
            输入	   In5	    string	流水号，20位数字，每个请求流水号要求唯一（规则自定义,建议时间格式精确到毫秒）必填参数，与回执接口中的流水号一一对应，不传后面回执接口无法查询数据。
            输入	   In6	    string	预约发送时间，格式:yyyyMMddHHmmss,如‘20090901010101’， 立即发送请填空（预约时间要写当前时间5分钟之后的时间，若预约时间少于5分钟，则为立即发送。）
            输入	   In7	    string	提交时检测方式
                                    1 --- 提交号码中有效的号码仍正常发出短信，无效的号码在返回参数faillist中列出
                                    不为1 或该参数不存在 --- 提交号码中只要有无效的号码，那么所有的号码都不发出短信，所有的号码在返回参数faillist中列出
            输入	   In8	    string	保留（空值）
            输入	   In9	    string	接入号扩展号（默认不填，扩展号为数字，扩展位数由当前所配的接入号长度决定，整个接入号最长20位）
            输入	   In10	    string	保留（空值）
        */
        public async Task<string> Send(string telephone, string msg)
        {
            try
            {
                SmsPortTypeClient SmsSurport = SmsSurport = new SmsPortTypeClient(new BasicHttpBinding(), new EndpointAddress(E_SMS_URL));
                var response = await SmsSurport.SmsAsync(Crop_NO, UName, UPwd, msg, telephone.Trim(), DateTime.Now.ToString("yyyyMMddHHmmssfff") + "000", "", "1", "", "", "");
                //LoggHelper.GetInstance().LogInfo("", "");
                return response.@out;

               
                //SqlDataHelper_IH.WriteLlFile("[创业短信] Mobiles[" + telephone.Trim() + "]发送成功！流水号是：" + sResult + "\r", "_SMSoc");

            }
            catch (Exception ex)
            {
                // SqlDataHelper_IH.WriteLoclFile("[创业短信] Mobiles[" + telephone.Trim() + "]发送失败！ERROR：" + ex.Message + "\r", "_SMS");
                throw ex;
            }
        }

        #endregion
    }
}
