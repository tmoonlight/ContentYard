using System;
using System.Collections.Generic;
using System.Text;
using DapperExtensions;

namespace CY_System.Infrastructure.Repository
{
    /// <summary>
    /// 谓词构造器,用于将where子句转换为dapper expression中的谓词
    /// </summary>
    public class PredicateBuilder
    {
        /// <summary>
        /// 单个谓词构造器(LIKE关键字必须大写)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression">包含"<",">","="的简单查询子句</param>
        /// <returns></returns>
        public static IPredicate BuildSinglePredicate<T>(string expression) where T : class
        {
            bool IsNot = false;
            string[] strs = null;
            Operator op = default(Operator);
            //参数校验
            if (string.IsNullOrEmpty(expression)) return null;
            //判断并分割表达式
            if (expression.Contains(">="))
            {
                strs = expression.Split(new string[] { ">=" }, StringSplitOptions.None);
                op = PredicateBuilder.OperatorStringDict[">="];
            }
            else if (expression.Contains("<="))
            {
                strs = expression.Split(new string[] { "<=" }, StringSplitOptions.None);
                op = PredicateBuilder.OperatorStringDict["<="];
            }
            else if (expression.Contains("<>"))
            {
                strs = expression.Split(new string[] { "<>" }, StringSplitOptions.None);
                op = PredicateBuilder.OperatorStringDict["="];
                IsNot = true;
            }
            else if (expression.Contains("!="))
            {
                strs = expression.Split(new string[] { "!=" }, StringSplitOptions.None);
                op = PredicateBuilder.OperatorStringDict["="];
                IsNot = true;
            }
            else if (expression.Contains("="))
            {
                strs = expression.Split(new string[] { "=" }, StringSplitOptions.None);
                op = PredicateBuilder.OperatorStringDict["="];
            }
            else if (expression.Contains(">"))
            {
                strs = expression.Split(new string[] { ">" }, StringSplitOptions.None);
                op = PredicateBuilder.OperatorStringDict[">"];
            }
            else if (expression.Contains("<"))
            {
                strs = expression.Split(new string[] { "<" }, StringSplitOptions.None);
                op = PredicateBuilder.OperatorStringDict["<"];
            }
            else if (expression.Contains("LIKE"))
            {
                strs = expression.Split(new string[] { "LIKE" }, StringSplitOptions.None);
                op = PredicateBuilder.OperatorStringDict["LIKE"];
            }
            //以下写法删除,不允许小写的like
            //else if (expression.Contains("like"))
            //{
            //    strs = expression.Split(new string[] { "LIKE" }, StringSplitOptions.None);
            //    op = PredicateBuilder.OperatorStringDict["LIKE"];
            //}

            if (strs.Length < 2) return null;
            var predicate = Predicates.Field<T>(strs[0].Trim(), op, strs[1].Trim()
                .Replace("\"", "").Replace("'", ""), IsNot);
            return predicate;
        }

        public static string[] OperatorStrings = new string[] {
                ">",
                ">=",
                "<",
                "<=",
                "NOT LIKE",
                "LIKE",
                "="
            };

        public static Dictionary<string, Operator> OperatorStringDict = new Dictionary<string, Operator>
        {
            {">",Operator.Gt },
            {">=",Operator.Ge },
            {"<",Operator.Lt },
            {"<=",Operator.Le },
            {"LIKE",Operator.Like },
            {"=",Operator.Eq },
        };

        /// <summary>
        /// 谓词组合构造器(只能AND,注意AND必须大写)
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="expression">表达式</param>
        /// <returns></returns>
        public static IPredicateGroup BuildGroupPredicate<T>(string expression) where T : class
        {

            var strs = expression.Split(new string[] { "AND" },StringSplitOptions.None);
            PredicateGroup predicateGroup = new PredicateGroup() {
                Operator = GroupOperator.And,
                Predicates = new List<IPredicate>()
            };
            
            foreach (string str in strs)
            {
                var pred = BuildSinglePredicate<T>(str);
                predicateGroup.Predicates.Add(pred);
            }
            //PredicateGroup
            return predicateGroup;
        }
    }
}
