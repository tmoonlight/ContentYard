using AutoMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CY_System.Service.Extensions
{
    /// <summary>   
    /// AutoMapper扩展方法   
    /// </summary>   
    public static class AutoMapperExtensions
    {
        /// <summary>
        /// 类型映射
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="IgnoreNullValue">如果为true则表示不映射值为null或者""的属性/字段</param>
        /// <returns></returns>
        public static T MapTo<T>(this object obj, bool IgnoreNullValue = false)
        {
            if (obj == null) return default(T);

            MapperConfiguration mc = new MapperConfiguration(cfg =>
            {

                var map = cfg.CreateMap(obj.GetType(), typeof(T));
                if (IgnoreNullValue)
                {
                    map.ForAllMembers(opt => { opt.Condition(src => !(src == null || src.ToString() == "")); });
                }
                //if (IgnoreNullValue)
                //{
                //    cfg.CreateMap(obj.GetType(), typeof(T)).ForAllMembers(opt => { opt.Condition(src => !(src == null || src.ToString() == "")); });
                //}
                //else
                //{
                //    cfg.CreateMap(obj.GetType(), typeof(T));
                //}
            });
            return mc.CreateMapper().Map<T>(obj);
        }

        /// <summary>
        /// 集合列表(带泛型)类型映射(支持动态类型)
        /// </summary>
        public static IEnumerable<TDestination> MapToList<TSource, TDestination>(this IEnumerable<TSource> source, bool IgnoreNullValue = false)
        {
            //IEnumerable<T> 类型需要创建元素的映射
            MapperConfiguration mc = new MapperConfiguration(cfg =>
            {
                var map = cfg.CreateMap<TSource, TDestination>();
                if (IgnoreNullValue)
                {
                    map.ForAllMembers(opt => { opt.Condition(src => !(src == null || src.ToString() == "")); });
                }
                cfg.CreateMissingTypeMaps = true;
            });

            return mc.CreateMapper().Map<IEnumerable<TDestination>>(source);
        }

        /// <summary>
        /// 集合列表(带泛型)类型映射(支持动态类型,简化形式)
        /// </summary>
        public static IEnumerable<TDestination> MapToList<TDestination>(this IEnumerable<Object> source, bool IgnoreNullValue = false)
        {
            //IEnumerable<T> 类型需要创建元素的映射
            MapperConfiguration mc = new MapperConfiguration(cfg =>
            {
                var map = cfg.CreateMap(source.GetType().GenericTypeArguments[0], typeof(TDestination));
                if (IgnoreNullValue)
                {
                    map.ForAllMembers(opt => { opt.Condition(src => !(src == null || src.ToString() == "")); });
                }
                cfg.CreateMissingTypeMaps = true;
            });
            return mc.CreateMapper().Map<IEnumerable<TDestination>>(source);
        }

        /// <summary>
        /// 类型映射
        /// </summary>
        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
            where TSource : class
            where TDestination : class
        {
            if (source == null) return destination;
            MapperConfiguration mc = new MapperConfiguration(cfg => cfg.CreateMap<TSource, TDestination>());
            return mc.CreateMapper().Map(source, destination);
        }

        /// <summary>
        /// DataReader映射
        /// </summary>
        public static IEnumerable<T> DataReaderMapTo<T>(this IDataReader reader)
        {
            Mapper.Reset();
            MapperConfiguration mc = new MapperConfiguration(cfg => cfg.CreateMap<IDataReader, IEnumerable<T>>());
            return mc.CreateMapper().Map<IDataReader, IEnumerable<T>>(reader);
        }
    }
}
