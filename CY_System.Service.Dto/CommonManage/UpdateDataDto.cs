using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CY_System.Service.Dto
{
    /// <summary>
    /// 客户相关信息：客户分类、客户信息、联系人信息
    /// 客户分类
    /// 作者：田大伟
    /// 时间：2015-03-03 9:50:10
    /// </summary>
    //[DataContract(Namespace = Namespaces.EntitiesNamespace)]
    public class UpdateDataDto
    {
        /// <summary>
        /// 初始化构造函数
        /// </summary>
        public UpdateDataDto()
        {
            this.objKey1s = new List<object>();
            this.objKey2s = new List<object>();
            this.objKey3s = new List<object>();

            this.KeyValuePairs = new Dictionary<string, object>();
            this.KeyValuePairsList = new List<Dictionary<string, object>>();
        }
          
        /// <summary>
        /// 主键1
        /// </summary>
        public object objKey1 { get; set; }

        /// <summary>
        /// 主键2
        /// </summary>
        public object objKey2 { get; set; }

        /// <summary>
        /// 主键3
        /// </summary>
        public object objKey3 { get; set; }

        /// <summary>
        /// 主键1数组
        /// </summary>
        public List<object> objKey1s { get; set; }

        /// <summary>
        /// 主键2数组
        /// </summary>
        public List<object> objKey2s { get; set; }

        /// <summary>
        /// 主键3数组
        /// </summary>
        public List<object> objKey3s { get; set; }

        /// <summary>
        /// 待更新数据集合
        /// </summary>
        public Dictionary<string, object> KeyValuePairs { get; set; }

        /// <summary>
        /// 待更新数据集合
        /// </summary>
        public List<Dictionary<string, object>> KeyValuePairsList { get; set; }
    }
}
