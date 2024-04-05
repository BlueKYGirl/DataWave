using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServiceManager
    {
        IPlanUserService PlanUser { get; }
        IPlanService Plan { get; }
        IDeviceService Device { get; }
        IUserService User { get; }


    }
}
