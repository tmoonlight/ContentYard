using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
    /// 数据库类型
    /// </summary>
    public enum DBType
    {
        SqlServer = 0, //默认值
        MySql = 1,
        Oracle = 2,
        Redis = 3
    }
    /// <summary>
    /// 标识这是一个支持最简单增删改查的仓储接口
    /// </summary>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        ///  获取数据库类型(默认为SqlServer)
        /// </summary>
        DBType GetDBType { get; }

        /// <summary>
        /// 查询是否存在该记录
        /// </summary>
        /// <param name="m_flowid">关键字</param>
        /// <param name="strWhere">条件语句</param>
        /// <returns></returns>
        bool Exists(ValueType id);

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model">要往数据库中的添加的实体对象</param>
        /// <returns>结果</returns>
        int Add(T model);
        

        /// <summary>
        /// 更新一条记录
        /// </summary>
        /// <param name="model">需要更新的数据</param>
        /// <returns>更新结果</returns>
        int Update(T model);
        

        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="m_flowid">关键字</param>
        /// <param name="strWhere">条件删除</param>
        /// <returns>删除结果</returns>
        int Delete(ValueType id);
        

        /// <summary>
        /// 获得单个实体对象
        /// </summary>
        /// <param name="m_flowid">关键字</param>
        /// <returns>实体对象</returns>
        T SelectModel(ValueType id);


        /// <summary>
        /// 根据条件查询实体记录
        /// </summary>
        /// <param name="predicate">谓词查询条件</param>
        /// <returns>实体记录</returns>
        IEnumerable<T> SelectList(object predicate);


        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="pageSize">页面显示的行数</param>
        /// <param name="pageIndex">页号</param>
        /// <param name="pageCount">总行数</param>
        /// <param name="strSort">排序字段</param>
        /// <param name="bAsc">升序或降序</param>
        /// <returns>根据分页查询的数据</returns>
        IEnumerable<T> SelectByPaged(object predicate, int pageSize, int pageIndex, out int pageCount, string strSort, bool bAsc);


        /// <summary>
        /// 简化版查询,运行一次即关闭连接
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        IEnumerable<dynamic> RunSqlToList(string sql, object param = null);



        /// <summary>
        /// 简化版执行,返回影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        int RunSql(string sql, object param = null);
    }
}
