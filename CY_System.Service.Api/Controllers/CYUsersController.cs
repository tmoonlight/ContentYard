using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CY_System.DomainStandard;
using CY_System.Infrastructure;
using CY_System.Service.Dto;
using CY_System.Service.Extensions;
using CY_System.Infrastructure.Repository;
using AutoMapper;
using System.Dynamic;
using CY_System.Service;

namespace CY_System.Service.Controllers.CA
{
    /// <summary>
    /// CYUsers操作控制器
    /// </summary>
    [Produces("application/json")]
    [Route("api/CYUsers")]
    public class CYUsersController : Controller
    {
        //CYUsers仓库
        private CYUsersService service = new CYUsersService();

        /// <summary>
        /// 判断CYUsers是否存在
        /// </summary>
        /// <param name="m_id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Exists/{m_id}")]
        [ProducesResponseType(typeof(ErrorDto), 500)]
        public Result Exists(Guid m_id)
        {
            return Result.Success(service.Exists(m_id));
        }

        /// <summary>
        /// 新增CYUsers
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Add")]
        [ProducesResponseType(typeof(ErrorDto), 500)]
        public Result Add(CYUsersDto model)
        {
            return Result.Success(service.Add(model));
        }

        /// <summary>
        /// 修改CYUsers字段
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Update")]
        [ProducesResponseType(typeof(ErrorDto), 500)]
        public Result Update(CYUsersDto model)
        {
            return Result.Success(service.Update(model));
        }

        /// <summary>
        /// 删除CYUsers,物理删除.
        /// </summary>
        /// <param name="m_id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Delete/{m_id}")]
        [ProducesResponseType(typeof(ErrorDto), 500)]
        public Result Delete(Guid m_id)
        {
            return Result.Success(service.Delete(m_id));
        }

        /// <summary>
        /// 查询单个CYUsers实体
        /// </summary>
        /// <param name="m_id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("SelectModel/{m_id}")]
        [ProducesResponseType(typeof(ErrorDto), 500)]
        public Result SelectModel(Guid m_id)
        {
            return Result.Success(service.SelectModel(m_id));
        }

        /// <summary>
        /// 查询CYUsers列表
        /// </summary>
        /// <param name="predicateExpression"></param>
        /// <response code="205">查不到任何数据</response>
        /// <returns></returns>
        [HttpGet]
        [Route("SelectList")]
        [ProducesResponseType(205)]
        [ProducesResponseType(typeof(IEnumerable<CYUsersDto>), 200)]
        [ProducesResponseType(typeof(ErrorDto), 500)]
        public Result SelectList(string predicateExpression)
        {
            var pred = PredicateBuilder.BuildSinglePredicate<CYUsersInfo>(predicateExpression);
            var result = service.SelectList(predicateExpression);
            return Result.Success(result);

        }

        /// <summary>
        /// CYUsers
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="strSort"></param>
        /// <param name="bAsc"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("SelectByPaged")]
        [ProducesResponseType(205)]
        [ProducesResponseType(typeof(IEnumerable<CYUsersDto>), 200)]
        [ProducesResponseType(typeof(ErrorDto), 500)]
        public Result SelectByPaged(int pageSize, int pageIndex, string strSort, bool bAsc)
        {
            return Result.Success(service.SelectByPaged(pageSize, pageIndex, strSort, bAsc));
        }

    }
}