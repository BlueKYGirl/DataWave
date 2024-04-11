using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    public class PlanUserService : IPlanUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PlanUserService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<IEnumerable<PlanUserDto>> GetAllPlanUsersAsync(bool trackChanges)
        {
            var planUsers = await _repositoryManager.PlanUser.GetAllPlanUsersAsync(trackChanges);
            var planUsersDto = _mapper.Map<IEnumerable<PlanUserDto>>(planUsers);
            return planUsersDto;
        }
        public PlanUserDto GetPlanUser(Guid id, bool trackChanges)
        {
            var planUser = _repositoryManager.PlanUser.GetPlanUser(id, trackChanges);
            var planUserDto = _mapper.Map<PlanUserDto>(planUser);
            return planUserDto;
        }
        public async Task<PlanUserDto> GetPlanUserAsync(Guid id, bool trackChanges)
        {
            var planUser = await _repositoryManager.PlanUser.GetPlanUserAsync(id, trackChanges);
            var planUserDto = _mapper.Map<PlanUserDto>(planUser);
            return planUserDto;
        }
        public async Task<IEnumerable<PlanUserDto>> GetAllPlanUsersByUserIdAsync(Guid userId, bool trackChanges)
        {
            var planUsers = await _repositoryManager.PlanUser.GetPlansForUserAsync(userId, trackChanges);
            var planUsersDto = _mapper.Map<IEnumerable<PlanUserDto>>(planUsers);
            return planUsersDto;
        }
        public async Task<PlanUserDto> CreatePlanUserAsync(PlanUserForCreationDto planUser)
        {
            var planUserEntity = _mapper.Map<PlanUser>(planUser);
            _repositoryManager.PlanUser.CreatePlanUser(planUserEntity);
            await _repositoryManager.SaveAsync();
            var planUserToReturn = _mapper.Map<PlanUserDto>(planUserEntity);
            return planUserToReturn;
        }
    }
}
