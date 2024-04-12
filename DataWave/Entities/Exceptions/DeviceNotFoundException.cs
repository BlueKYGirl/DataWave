using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class DeviceNotFoundException :NotFoundException
    {
        public DeviceNotFoundException(Guid deviceId) : base($"Device with id {deviceId} was not found.")
        {
        }
        public DeviceNotFoundException(string phoneNumber) : base($"Device with phone number {phoneNumber} was not found.")
        {
        }
    }
}
