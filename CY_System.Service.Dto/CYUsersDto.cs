using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
	/// CYUsers数据传输实体类
    /// 作者: C
    /// 时间: 2018-04-18 15:53:40
    /// </summary>
    public class CYUsersDto
    {
        /// <summary>
        /// Id属性
        /// <summary>
        public long? Id { get; set; }

        /// <summary>
        /// 失败次数
        /// <summary>
        public int? AccessFailedCount { get; set; }

        /// <summary>
        /// AuthenticationSource属性
        /// <summary>
        public string AuthenticationSource { get; set; }

        /// <summary>
        /// 同步
        /// <summary>
        public string ConcurrencyStamp { get; set; }

        /// <summary>
        /// CreateTime属性
        /// <summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// CreateUserId属性
        /// <summary>
        public long? CreateUserId { get; set; }

        /// <summary>
        /// DeleteUserId属性
        /// <summary>
        public long? DeleteUserId { get; set; }

        /// <summary>
        /// DeletionTime属性
        /// <summary>
        public DateTime? DeletionTime { get; set; }

        /// <summary>
        /// 邮件
        /// <summary>
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// 激活码
        /// <summary>
        public string EmailConfirmationCode { get; set; }

        /// <summary>
        /// 激活
        /// <summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// 删除
        /// <summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// 邮件已确认
        /// <summary>
        public bool? IsEmailConfirmed { get; set; }

        /// <summary>
        /// IsLockoutEnabled属性
        /// <summary>
        public bool? IsLockoutEnabled { get; set; }

        /// <summary>
        /// 电话已确认
        /// <summary>
        public bool? IsPhoneNumberConfirmed { get; set; }

        /// <summary>
        /// IsTwoFactorEnabled属性
        /// <summary>
        public bool? IsTwoFactorEnabled { get; set; }

        /// <summary>
        /// LastLoginTime属性
        /// <summary>
        public DateTime? LastLoginTime { get; set; }

        /// <summary>
        /// LastEditTime属性
        /// <summary>
        public DateTime? LastEditTime { get; set; }

        /// <summary>
        /// LastEditUserId属性
        /// <summary>
        public long? LastEditUserId { get; set; }

        /// <summary>
        /// LockoutEndDateUtc属性
        /// <summary>
        public DateTime? LockoutEndDateUtc { get; set; }

        /// <summary>
        /// 姓名
        /// <summary>
        [Display(Name = "姓名")]
        public string Name { get; set; }

        /// <summary>
        /// 大写邮件地址
        /// <summary>
        public string NormalizedEmailAddress { get; set; }

        /// <summary>
        /// 大写用户名
        /// <summary>
        public string NormalizedUserName { get; set; }

        /// <summary>
        /// 密码
        /// <summary>
        [Required(ErrorMessage = "密码不能为空")]
        [StringLength(5,MinimumLength =3)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        /// <summary>
        /// 密码重置确认码
        /// <summary>
        public string PasswordResetCode { get; set; }

        /// <summary>
        /// 电话号码
        /// <summary>
        [Display(Name = "电话号码")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 安全标识
        /// <summary>
        public string SecurityStamp { get; set; }

        /// <summary>
        /// Surname属性
        /// <summary>
        public string Surname { get; set; }

        /// <summary>
        /// 用户名
        /// <summary>
        [StringLength(100)]
        [Display(Name = "用户名")]
        public string UserName { get; set; }


    }
}


