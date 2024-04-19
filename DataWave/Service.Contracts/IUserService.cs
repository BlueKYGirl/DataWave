using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAllUsersAsync(bool trackChanges);
        UserDto GetUser(Guid id, bool trackChanges);
        Task<UserDto> GetUserAsync(Guid id, bool trackChanges);
        Task<UserDto> CreateUserAsync(UserForCreationDto user);
        Task<User> AuthenticateUserAsync(string email, string password); 
    }
}
