using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IDeviceService> _deviceService;
        private readonly Lazy<IPlanService> _planService;
        private readonly Lazy<IPlanUserService> _planUserService;
        private readonly Lazy<IUserService> _userService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _deviceService = new Lazy<IDeviceService>(() => new DeviceService(repositoryManager, logger,mapper));
            _planService = new Lazy<IPlanService>(() => new PlanService(repositoryManager, logger, mapper));
            _planUserService = new Lazy<IPlanUserService>(() => new PlanUserService(repositoryManager, logger, mapper));
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, logger, mapper));
        }

        public IDeviceService Device => _deviceService.Value;

        public IPlanService Plan => _planService.Value;

        public IPlanUserService PlanUser => _planUserService.Value;

        public IUserService User => _userService.Value;

    }
}
