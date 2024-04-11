using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IPlanRepository
    {
        Task<IEnumerable<Plan>> GetAllPlansAsync(bool trackChanges);
        Task<Plan> GetPlanAsync(Guid id, bool trackChanges);
        Plan GetPlan(Guid id, bool trackChanges);
      
    }
}
