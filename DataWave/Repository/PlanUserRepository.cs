using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class PlanUserRepository : RepositoryBase<PlanUser>, IPlanUserRepository
    {
        public PlanUserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
        public async Task<IEnumerable<PlanUser>> GetAllPlanUsersAsync(bool trackchanges) =>
            await FindAll(trackchanges)
            .OrderBy(p => p.Id)
            .ToListAsync();
        public PlanUser GetPlanUser(Guid planUserId, bool trackChanges) =>
            FindByCondition(p => p.Id.Equals(planUserId), trackChanges)
            .SingleOrDefault();
        public async Task<PlanUser> GetPlanUserAsync(Guid planUserId, bool trackChanges) =>
            await FindByCondition(p => p.Id.Equals(planUserId), trackChanges)
            .SingleOrDefaultAsync();
        public async Task<IEnumerable<PlanUser>> GetPlansForUserAsync(Guid userId, bool trackChanges) =>
            await FindByCondition(p => p.UserId.Equals(userId), trackChanges).ToListAsync();

        public void CreatePlanUser(PlanUser planUser) => Create(planUser);
    }
}
