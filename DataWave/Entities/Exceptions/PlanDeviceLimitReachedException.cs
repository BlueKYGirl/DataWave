using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class PlanDeviceLimitReachedException : Exception
    {
        public PlanDeviceLimitReachedException(Guid planUserId) : base($"Plan with id {planUserId} has already reached the device limit.")
        {
        }
    }
}