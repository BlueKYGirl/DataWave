using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Contracts;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
        public async Task<IEnumerable<User>> GetAllUsersAsync(bool trackchanges) =>
            await FindAll(trackchanges)
            .OrderBy(u => u.LastName)
            .ToListAsync();
        public User GetUser(Guid userId, bool trackChanges) =>
            FindByCondition(u => u.Id.Equals(userId), trackChanges)
            .SingleOrDefault();
        public async Task<User> GetUserAsync(Guid userId, bool trackChanges) =>
            await FindByCondition(u => u.Id.Equals(userId), trackChanges)
            .SingleOrDefaultAsync();
        public void CreateUser(User user) => Create(user);
        public async Task<User> GetUserByEmailAndPasswordAsync(string email, string password, bool trackChanges) =>
            await FindByCondition(u => u.Email == email && u.Password == password, trackChanges)
            .SingleOrDefaultAsync();

    }
}
