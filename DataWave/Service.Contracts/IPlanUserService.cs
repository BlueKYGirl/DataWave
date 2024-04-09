using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IPlanUserService
    {
        Task<IEnumerable<PlanUserDto>> GetAllPlanUsersAsync(bool trackChanges);
        PlanUserDto GetPlanUser(Guid id, bool trackChanges);
        Task<PlanUserDto> GetPlanUserAsync(Guid id, bool trackChanges);
        Task<IEnumerable<PlanUserDto>> GetAllPlanUsersByUserIdAsync(Guid userId, bool trackChanges);
    }
}
