namespace CY_System.DomainStandard
{
    public class CY_SystemConsts
    {
        public const string LocalizationSourceName = "test";

        public const string ConnectionStringName = "Default";

        #region 服务名
        /// <summary>
        /// 可使用的入口服务名列表
        /// </summary>
        public const string ServiceProjectName = "CY_System.Service";
        public const string WcfServiceProjectName = "CY_System.WcfService";
        #endregion

        #region 数据库连接配置节名称
        /// <summary>
        /// 数据库连接配置节名称
        /// </summary>
        public const string ConnectionString_conn = "conn";
        public const string ConnectionString_conn_ih = "conn_ih";
        public const string ConnectionString_conn_ca = "conn_ca";
        public const string ConnectionString_connLog = "connLog";

        //public const bool MultiTenancyEnabled = true;
        #endregion

        #region jwtbearer相关参数
        public const string SecurityKey = "SKEGasddsSFSDFg453+#Q(%EWTSDGS345FGFDFgdfSC45RdfgWGSDFYfdsYZ";  //对称秘钥
        public const string TokenIssuer = "ERP_ISSUSER";                                    //有效token签发者
        public const string TokenAudience = "ERP";                                          //有效应用名
        #endregion

        #region 业务常量

        /// <summary>
        /// 模块常量
        /// </summary>
        public class FunModule
        {
            public const string StampHead = "承接业务主";
            public const string Stamp = "承接业务";
            public const string InsteadHandle = "代办业务";
            public const string Negative = "冲红业务";
            public const string CusDataInfo = "客户资料业务";
            public const string CustomerInfo = "客户信息";
            public const string LinkInfo = "联系人信息";
            public const string TransVouch = "财产调拨";
            public const string IhMattersCombo = "代办套餐";
            public const string frmContactsInfo = "frmContactsInfo";
            public const string CA = "数字证书";
            public const string Transport = "物流业务";
            public const string ErrorHandle = "异常申报";
            public const string BOM = "BOM业务";
            public const string PMS = "生产订单";
            public const string FinanceTaxation = "财税业务";
        }

        /// <summary>
        /// 数据格式设置
        /// </summary>
        public class FormatSet
        {
            public const string DoubleFormat = "#########0.00";
            public const string DateFormat = "yyyy-MM-dd";
        }
        #endregion


    }
}