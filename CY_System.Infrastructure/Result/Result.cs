using CY_System.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace CY_System.Infrastructure
{
    /**
 * 响应码枚举，参考HTTP状态码的语义
 */
    public enum ResultCode
    {
        [Description("SUCCESS")]
        SUCCESS = 1, //成功
        [Description("访问失败")]
        FAIL = 400,//失败
        [Description("签名错误")]
        UNAUTHORIZED = 401, //未认证（签名错误）
        [Description("此接口不存在")]
        NOT_FOUND = 404, //接口不存在
        [Description("系统繁忙,请稍后再试")]
        INTERNAL_SERVER_ERROR = 500, //服务器内部错误
        [Description("参数错误")]
        INVALID_PARAM = 10000,
    }
}

/// <summary>
/// 公共响应结果
/// </summary>
public class Result
{

    private static String DEFAULT_SUCCESS_MESSAGE = "SUCCESS";

    private int code;
    private String message;
    private Object data;

    public int Code { get => code; set => code = value; }
    public string Message { get => message; set => message = value; }
    public object Data { get => data; set => data = value; }

    public Result()
    {
    }

    public Result(ResultCode resultCode,object data = null)
    {
        this.Code = (int)resultCode;
        this.Message = GetDescription(resultCode);
        this.Data = data;
    }

    public static Result Success()
    {
        return new Result()
        {
            Code = (int)ResultCode.SUCCESS,
            Message = DEFAULT_SUCCESS_MESSAGE
        };
    }

    public static Result Success(Object data)
    {
        return new Result()
        {
            Code = (int)ResultCode.SUCCESS,
            Message = DEFAULT_SUCCESS_MESSAGE,
            Data = data
        };
      
    }

    public static Result Fail(String message)
    {
        return new Result()
        {
            Code = (int)ResultCode.FAIL,
            Message = message
        };
    }

    private string GetDescription(Enum value)
    {
        Type enumType = value.GetType();
        // 获取枚举常数名称。
        string name = Enum.GetName(enumType, value);
        if (name != null)
        {
            // 获取枚举字段。
            FieldInfo fieldInfo = enumType.GetField(name);
            if (fieldInfo != null)
            {
                // 获取描述的属性。
                DescriptionAttribute attr = Attribute.GetCustomAttribute(fieldInfo,
                    typeof(DescriptionAttribute), false) as DescriptionAttribute;
                if (attr != null)
                {
                    return attr.Description;
                }
            }
        }
        return null;
    }
}
