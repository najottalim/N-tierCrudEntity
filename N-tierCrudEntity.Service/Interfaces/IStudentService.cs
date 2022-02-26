using N_tierCrudEntity.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace N_tierCrudEntity.Service.Interfaces
{
    public interface IStudentService
    {
        Task<Student> GetAsync(Expression<Func<Student, bool>> predicate);

        Task<IEnumerable<Student>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<Student, bool>> predicate = null);

        Task<IEnumerable<Student>> GetAllInfoAsync(int pageSize, int pageIndex, Expression<Func<Student, bool>> predicate = null);
    }
}
