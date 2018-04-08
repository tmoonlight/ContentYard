using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using DapperExtensions;
using System.Linq.Expressions;
using CY_System.DomainStandard;
using System.Data;

namespace CY_System.Infrastructure
{
    /// <summary>
    /// 通用仓储类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseRepository_CA<T> : IRepository<T> where T : class
    {
        private string _connectionString;

        public DBType GetDBType { get; }

        public IDbConnection GetConnection()
        {
            return ConnectionFactory.CreateConnection(_connectionString);
        }

        public BaseRepository_CA()
        {
            this._connectionString = CY_SystemConsts.ConnectionString_conn_ca;
        }

        public virtual int Add(T model)
        {
            //取得实体上的连接
            using (var conn = GetConnection())
            {
                conn.Insert(model);
                return 1;
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="m_flowid"></param>
        /// <returns></returns>
        public virtual int Delete(ValueType m_flowid)
        {
            using (var conn = GetConnection())
            {
                var obj = conn.Get<T>(m_flowid);
                if (obj == null)
                {
                    return 0;
                }
                if (conn.Delete(obj))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }


        /// <summary>
        /// 判断是否存在
        /// </summary>
        /// <param name="m_flowid"></param>
        /// <returns></returns>
        public virtual bool Exists(ValueType m_flowid)
        {
            using (var conn = GetConnection())
            {
                //获取主键
                //var predicate = Predicates.Field<T>(f => null, Operator.Eq, 1);
                return conn.Count<T>(null) > 0;
            }
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageCount"></param>
        /// <param name="strSort"></param>
        /// <param name="bAsc"></param>
        /// <returns></returns>
        public virtual IEnumerable<T> SelectByPaged(object predicate, int pageSize, int pageIndex, out int pageCount, string strSort, bool bAsc)
        {
            using (var conn = GetConnection())
            {
                int count = conn.Count<T>(predicate);
                pageCount = count / pageSize;
                if (count % pageSize > 0)
                {
                    pageCount++;
                }

                return conn.GetPage<T>(predicate, new List<ISort>() { new Sort() { PropertyName = strSort, Ascending = bAsc } }, pageIndex, pageSize, buffered: true);
            }
        }

        /// <summary>
        /// 查询列表(实现不完全),失败则返回null
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public virtual IEnumerable<T> SelectList(object predicate)
        {
            using (var conn = GetConnection())
            {
                return conn.GetList<T>(predicate: predicate, buffered: true);
            }
        }

        /// <summary>
        /// 查询单个实体,失败则返回null
        /// </summary>
        /// <param name="m_flowid"></param>
        /// <returns></returns>
        public virtual T SelectModel(ValueType m_flowid)
        {
            using (var conn = GetConnection())
            {
                return conn.Get<T>(m_flowid);
            }
        }

        /// <summary>
        /// 更新,失败则返回-1
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual int Update(T model)
        {
            using (var conn = GetConnection())
            {
                conn.Update(model);
                return 1;
            }
        }

        /// <summary>
        /// 按查询表达式查出值,如:Where ContractID="123" 则写成:
        /// XXX.Find(f=>f.ContractID,Operater.Eq,"123");支持组合条件查询
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="op"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public virtual IEnumerable<T> Find(object predicate)
        {
            using (var conn = GetConnection())
            {

                if (predicate == null)
                {
                    return conn.GetList<T>(predicate);
                }
                else
                {
                    return conn.GetList<T>(predicate, buffered: true);
                }
            }
        }

        /// <summary>
        /// 简化版查询,运行一次即关闭连接
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public virtual IEnumerable<dynamic> RunSqlToList(string sql, object param = null)
        {
            using (var conn = GetConnection())
            {
                return conn.Query(sql, param, buffered: true);
            }
        }


        /// <summary>
        /// 简化版执行,返回影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public virtual int RunSql(string sql, object param = null)
        {
            using (var conn = GetConnection())
            {
                return conn.Execute(sql, param);
            }
        }
    }
}
