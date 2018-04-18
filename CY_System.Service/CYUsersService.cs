using CY_System.DomainStandard;
using CY_System.Infrastructure.Repository;
using CY_System.Service.Dto;
using CY_System.Service.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CY_System.Service
{
    /// <summary>
    /// CYUsers操作控制器
    /// </summary>
    public class CYUsersService
    {
        //CYUsers仓库
        private CYUsersRepository repository = new CYUsersRepository();

        /// <summary>
        /// 判断CYUsers是否存在
        /// </summary>
        /// <param name="m_id"></param>
        /// <returns></returns>
        public bool Exists(Guid m_id)
        {
            return repository.Exists(m_id);
        }

        /// <summary>
        /// 新增CYUsers
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add(CYUsersDto model)
        {
            CYUsersInfo dto = model.MapTo<CYUsersInfo>();
            return repository.Add(dto);
        }

        /// <summary>
        /// 修改CYUsers字段
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Update(CYUsersDto model)
        {
            return repository.Update(model.MapTo<CYUsersInfo>());
        }

        /// <summary>
        /// 删除CYUsers,物理删除.
        /// </summary>
        /// <param name="m_id"></param>
        /// <returns></returns>
        public int Delete(Guid m_id)
        {
            return repository.Delete(m_id);
        }

        /// <summary>
        /// 查询单个CYUsers实体
        /// </summary>
        /// <param name="m_id"></param>
        /// <returns></returns>
        public CYUsersDto SelectModel(Guid m_id)
        {
            return repository.SelectModel(m_id).MapTo<CYUsersDto>();
        }

        /// <summary>
        /// 查询CYUsers列表
        /// </summary>
        /// <param name="predicateExpression"></param>
        /// <response code="205">查不到任何数据</response>
        /// <returns></returns>
        public IEnumerable<CYUsersDto> SelectList(string predicateExpression)
        {
            var pred = PredicateBuilder.BuildSinglePredicate<CYUsersInfo>(predicateExpression);
            IEnumerable<CYUsersInfo> result = repository.SelectList(pred);
            return result.MapToList<CYUsersInfo, CYUsersDto>();
        }

        /// <summary>
        /// CYUsers
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="strSort"></param>
        /// <param name="bAsc"></param>
        /// <returns></returns>
        public PagedDto<CYUsersDto> SelectByPaged(int pageSize, int pageIndex, string strSort, bool bAsc)
        {
            int pageCount = 0;
            PagedDto<CYUsersDto> dto = new PagedDto<CYUsersDto>();
            dto.Data = repository.SelectByPaged(null, pageSize, pageIndex, out pageCount, strSort, bAsc).MapToList<CYUsersInfo, CYUsersDto>().ToList();
            dto.PageCount = pageCount;
            return dto;
        }

    }
}
