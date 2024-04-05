using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IUserRepository User { get; }
        IDeviceRepository Device { get; }
        IPlanRepository Plan { get; }
        IPlanUserRepository PlanUser { get; }
        void Save();
        Task SaveAsync();
    }
}
