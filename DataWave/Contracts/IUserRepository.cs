using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Contracts
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges);
        Task<User> GetUserAsync(Guid id, bool trackChanges);
        User GetUser(Guid id, bool trackChanges);
        void CreateUser(User user);
        Task<User> GetUserByEmailAndPasswordAsync(string email, string password, bool trackChanges);
    }
}
