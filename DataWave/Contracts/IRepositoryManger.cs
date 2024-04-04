using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManger
    {
        IUserRepository UserRepository { get; }
        IDeviceRepository DeviceRepository { get; }
        IPlanRepository PlanRepository { get; }
        IPlanUserRepository PlanUserRepository { get; }
        void Save();
        Task SaveAsync();
    }
}
