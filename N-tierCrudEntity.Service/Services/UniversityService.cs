using N_tierCrudEntity.Domain;
using N_tierCrudEntity.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace N_tierCrudEntity.Service.Services
{
    public class UniversityService : IUniversityService
    {
        public Task<IEnumerable<University>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<University, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<University>> GetAllInfoAsync(int pageSize, int pageIndex, Expression<Func<University, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<University> GetAsync(Expression<Func<University, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
