using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    public class PlanService : IPlanService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PlanService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<IEnumerable<PlanDto>> GetAllPlansAsync(bool trackChanges)
        {
            var plans = await _repositoryManager.Plan.GetAllPlansAsync(trackChanges);
            var plansDto = _mapper.Map<IEnumerable<PlanDto>>(plans);
            return plansDto;
        }
        public PlanDto GetPlan(Guid id, bool trackChanges)
        {
            var plan = _repositoryManager.Plan.GetPlan(id, trackChanges);
            var planDto = _mapper.Map<PlanDto>(plan);
            return planDto;
        }
        public async Task<PlanDto> GetPlanAsync(Guid id, bool trackChanges)
        {
            var plan = await _repositoryManager.Plan.GetPlanAsync(id, trackChanges);
            var planDto = _mapper.Map<PlanDto>(plan);
            return planDto;
        }
    }
}
