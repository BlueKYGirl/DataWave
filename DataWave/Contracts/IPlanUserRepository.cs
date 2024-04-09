using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IPlanUserRepository
    {
        Task<IEnumerable<PlanUser>> GetAllPlanUsersAsync(bool trackChanges);
        Task<PlanUser> GetPlanUserAsync(Guid id, bool trackChanges);
        PlanUser GetPlanUser(Guid id, bool trackChanges);
        Task<IEnumerable<PlanUser>> GetPlansForUserAsync(Guid userId, bool trackChanges);
    }
}
