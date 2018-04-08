using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CY_System.Infrastructure
{
    /// <summary>
    /// 自定义表映射规则类,用于dapperextension的映射
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CustomPluralizedMapper<T> : ClassMapper<T> where T : class
    {
        public CustomPluralizedMapper()
        {
            Type type = typeof(T);
            Table(type.Name);
            AutoMap();
        }
        /// <summary>
        /// 映射规则,如果表名和实体差异太大,请直接使用POCO特性
        /// </summary>
        /// <param name="tbname"></param>
        public override void Table(string tbname)
        {
            var attrArray = this.EntityType.GetCustomAttributes(typeof(CY_System.DomainStandard.POCOAttribute), false);
            string newTableName = "";

            //使用特性之后的规则
            if (attrArray.Length > 0)
            {
                var attr = attrArray[0] as CY_System.DomainStandard.POCOAttribute;
                if (attr.TableName != null)
                {
                    newTableName = attr.TableName;
                }
            }
            //如果表格已经由特性标注过了,则直接执行父类table,否则执行当前table进行转换
            if (newTableName == "")
            {
                //如果没有属性,则使用默认规则
                if (tbname.EndsWith("Info"))
                {
                    newTableName = tbname.Substring(0, tbname.Length - 4);
                }
                else
                {
                    newTableName = tbname;
                }
            }

            base.Table(newTableName);
        }

        /// <summary>
        /// 重写字段映射规则
        /// </summary>
        /// <param name="canMap"></param>
        protected override void AutoMap(Func<Type, PropertyInfo, bool> canMap)
        {
            Type type = typeof(T);
            bool hasDefinedKey = Properties.Any(p => p.KeyType != KeyType.NotAKey);
            PropertyMap keyMap = null;
            foreach (var propertyInfo in type.GetProperties())
            {
                if (Properties.Any(p => p.Name.Equals(propertyInfo.Name, StringComparison.InvariantCultureIgnoreCase)))
                {
                    continue;
                }

                if ((canMap != null && !canMap(type, propertyInfo)))
                {
                    continue;
                }

                PropertyMap map = Map(propertyInfo);

                //标识列属性,如果存在此属性则忽略后续规则
                var attrArray = propertyInfo.GetCustomAttributes(typeof(CY_System.DomainStandard.IdentityAttribute), false);
                if (attrArray.Length > 0)
                {
                    keyMap = map;
                    continue;
                }

                //如果找不到标识列属性,就去找一个包含ID串的属性
                if (!hasDefinedKey)
                {

                    if (string.Equals(map.PropertyInfo.Name, "id", StringComparison.InvariantCultureIgnoreCase))
                    {
                        keyMap = map;
                    }

                    if (keyMap == null && map.PropertyInfo.Name.EndsWith("id", true, CultureInfo.InvariantCulture))
                    {
                        keyMap = map;
                    }
                }
            }

            if (keyMap != null)
            {
                keyMap.Key(PropertyTypeKeyTypeMapping.ContainsKey(keyMap.PropertyInfo.PropertyType)
                    ? PropertyTypeKeyTypeMapping[keyMap.PropertyInfo.PropertyType]
                    : KeyType.Assigned);
            }
        }
    }
}
