using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IDeviceRepository> _deviceRepository;
        private readonly Lazy<IPlanRepository> _planRepository;
        private readonly Lazy<IPlanUserRepository> _planUserRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_repositoryContext));
            _deviceRepository = new Lazy<IDeviceRepository>(() => new DeviceRepository(_repositoryContext));
            _planRepository = new Lazy<IPlanRepository>(() => new PlanRepository(_repositoryContext));
            _planUserRepository = new Lazy<IPlanUserRepository>(() => new PlanUserRepository(_repositoryContext));
        }

        public IUserRepository User => _userRepository.Value;
        public IDeviceRepository Device => _deviceRepository.Value;
        public IPlanRepository Plan => _planRepository.Value;
        public IPlanUserRepository PlanUser => _planUserRepository.Value;
        
        public void Save() => _repositoryContext.SaveChanges();
        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
