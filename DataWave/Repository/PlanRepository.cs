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
    public class PlanRepository : RepositoryBase<Plan>, IPlanRepository
    {
        public PlanRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
        public async Task<IEnumerable<Plan>> GetAllPlansAsync(bool trackchanges) =>
            await FindAll(trackchanges)
            .OrderBy(p => p.PlanName)
            .ToListAsync();
        public Plan GetPlan(Guid planId, bool trackChanges) =>
            FindByCondition(p => p.Id.Equals(planId), trackChanges)
            .SingleOrDefault();
        public async Task<Plan> GetPlanAsync(Guid planId, bool trackChanges) =>
            await FindByCondition(p => p.Id.Equals(planId), trackChanges)
            .SingleOrDefaultAsync();
    }
}
