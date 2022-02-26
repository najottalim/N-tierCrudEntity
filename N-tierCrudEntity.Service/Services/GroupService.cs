using Microsoft.EntityFrameworkCore;
using N_tierCrudEntity.Data.IRepositories;
using N_tierCrudEntity.Data.Repositories;
using N_tierCrudEntity.Domain;
using N_tierCrudEntity.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace N_tierCrudEntity.Service.Services
{
    public class GroupService : IGroupService
    {
        private IGroupRepository _groupRepo;
        public GroupService()
        {
            _groupRepo = new GroupRepository();
        }
        public async Task<IEnumerable<Group>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<Group, bool>> predicate = null)
        {
            var groups = await _groupRepo.GetAllAsync(predicate);

            return await groups.Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToListAsync();
        }

        public async Task<IEnumerable<Group>> GetAllInfoAsync(int pageSize, int pageIndex, Expression<Func<Group, bool>> predicate = null)
        {
            var groups = await _groupRepo.GetAllAsync(predicate);

            return groups.Include(x => x.University).Include(x => x.Students).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
        }

        public async Task<Group> GetAsync(Expression<Func<Group, bool>> predicate)
        {
            return await _groupRepo.GetAsync(predicate);
        }
    }
}
