using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IPlanService
    {
        Task<IEnumerable<PlanDto>> GetAllPlansAsync(bool trackChanges);
        PlanDto GetPlan(Guid id, bool trackChanges);
        Task<PlanDto> GetPlanAsync(Guid id, bool trackChanges);
    }
}
