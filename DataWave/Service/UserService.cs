using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Contracts;
using Entities;
using Contracts;
using Shared.DataTransferObjects;
using AutoMapper; 

namespace Service
{
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public UserService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<IEnumerable<UserDto>> GetAllUsersAsync(bool trackChanges)
        {
            var users = await _repositoryManager.User.GetAllUsersAsync(trackChanges);
           var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);
            return usersDto;
        }
        public UserDto GetUser(Guid id, bool trackChanges)
        {
            var user = _repositoryManager.User.GetUser(id, trackChanges);
            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }
        public async Task<UserDto> GetUserAsync(Guid id, bool trackChanges)
        {
            var user = await _repositoryManager.User.GetUserAsync(id, trackChanges);
            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }
        public async Task<UserDto> CreateUserAsync(UserForCreationDto user)
        {
            var userEntity = _mapper.Map<User>(user);
           
            _repositoryManager.User.CreateUser(userEntity);
            await _repositoryManager.SaveAsync();
            var userToReturn = _mapper.Map<UserDto>(userEntity);
            return userToReturn;
        }
        // public async Task<UserDevicesDto> GetUserDevicesAsync(Guid id, bool trackChanges)
        // {
        //     var user = await _repositoryManager.User.GetUserAsync(id, trackChanges);
        //     var userDevicesDto = _mapper.Map<UserDevicesDto>(user);
        //     return userDevicesDto;
        // }
    }
}
