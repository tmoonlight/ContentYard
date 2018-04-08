using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using Dapper;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using SealWebService;
using System.Threading.Tasks;
using CY_System.DomainStandard;
using System.ComponentModel.DataAnnotations;

namespace CY_System.Infrastructure
{
  
    public class EntityValidationResult
    {
        public EntityValidationResult(IList<ValidationResult> errors = null)
        {
            Errors = errors ?? new List<ValidationResult>();
        }
        public IList<ValidationResult> Errors { get; private set; }
        public bool HasError
        {
            get { return Errors.Count > 0; }
        }
    }

    public class EntityValidator<T> where T : class
    {
        public EntityValidationResult Validate(T entity)
        {
            var validationResults = new List<ValidationResult>();
            var vc = new ValidationContext(entity, null, null);
            var isValid = Validator.TryValidateObject
                    (entity, vc, validationResults, true);

            return new EntityValidationResult(validationResults);
        }
    }

    /// <summary>
    /// 集成.net注解验证帮助类
    /// </summary>
    public class ValidationHelper
    {
        public static EntityValidationResult ValidateEntity<T>(T entity)
            where T : class
        {
            return new EntityValidator<T>().Validate(entity);
        }
    }
}

