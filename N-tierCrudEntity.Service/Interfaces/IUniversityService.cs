using N_tierCrudEntity.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace N_tierCrudEntity.Service.Interfaces
{
    public interface IUniversityService
    {
        Task<University> GetAsync(Expression<Func<University, bool>> predicate);

        Task<IEnumerable<University>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<University, bool>> predicate = null);

        Task<IEnumerable<University>> GetAllInfoAsync(int pageSize, int pageIndex, Expression<Func<University, bool>> predicate = null);
    }
}
