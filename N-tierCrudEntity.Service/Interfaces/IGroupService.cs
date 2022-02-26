using N_tierCrudEntity.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace N_tierCrudEntity.Service.Interfaces
{
    public interface IGroupService
    {
        Task<Group> GetAsync(Expression<Func<Group, bool>> predicate);

        Task<IEnumerable<Group>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<Group, bool>> predicate = null);

        Task<IEnumerable<Group>> GetAllInfoAsync(int pageSize, int pageIndex, Expression<Func<Group, bool>> predicate = null);
    }
}
