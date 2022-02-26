using N_tierCrudEntity.Data.IRepositories;
using N_tierCrudEntity.Data.Repositories;
using N_tierCrudEntity.Domain;
using N_tierCrudEntity.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace N_tierCrudEntity.Service.Services
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _studentRepo;
        public StudentService()
        {
            _studentRepo = new StudentRepository();
        }

        public Task<IEnumerable<Student>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<Student, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Student>> GetAllInfoAsync(int pageSize, int pageIndex, Expression<Func<Student, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task<Student> GetAsync(Expression<Func<Student, bool>> predicate)
        {
            return await _studentRepo.GetAsync(predicate);
        }
    }
}
