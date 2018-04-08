using System.Runtime.Serialization;
using System.Data.SqlClient;

namespace CY_System.Service.Dto
{
    /// <summary>
    /// 数据命名空间
    /// </summary>
    public static class Namespaces
    {
        public const string RootNamespace = "urn:example";
        public const string ServiceNamespace = RootNamespace + ":services";
        public const string EntitiesNamespace = RootNamespace + ":entities";
    }

    /// <summary>
    /// 数据操作类型
    /// </summary>
    
    public enum TState
    {
        /// <summary>
        /// 数据状态——未改变
        /// </summary>
        
        None = 0,
        /// <summary>
        /// 数据状态——新增
        /// </summary>
        
        Added = 1,
        /// <summary>
        /// 数据状态——修改
        /// </summary>
        
        Modified = 2,
        /// <summary>
        /// 数据状态——删除
        /// </summary>
        
        Deleted = 3
    }

    /// <summary>
    /// 实体基类
    /// </summary>
    public class BasicClass
    {
    }

    
    public class SerSqlParameter
    {
        public SerSqlParameter(SqlParameter sPara)
        {
            this.paraName = sPara.ParameterName;
            this.paraLen = sPara.Size;
            this.paraVal = sPara.Value;
            this.sqlDbType = sPara.SqlDbType;
        }

        public SqlParameter ToSqlParameter()
        {
            SqlParameter para = new SqlParameter(this.paraName, this.sqlDbType, this.paraLen);
            para.Value = this.paraVal;
            return para;
        }

        private string paraName = "";
        public string ParaName
        {
            get { return this.paraName; }
            set { this.paraName = value; }
        }

        private int paraLen = 0;
        public int ParaLen
        {
            get { return this.paraLen; }
            set { this.paraLen = value; }
        }

        private object paraVal = null;
        public object ParaVal
        {
            get { return this.paraVal; }
            set { this.paraVal = value; }
        }

        private System.Data.SqlDbType sqlDbType = System.Data.SqlDbType.NVarChar;
        public System.Data.SqlDbType SqlDbType
        {
            get { return this.sqlDbType; }
            set { this.sqlDbType = value; }
        }
    }

    public class Hint
    {
        /// <summary>
        /// 
        /// <summary>
        public int ID { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string cMemo { get; set; }

    }
}
