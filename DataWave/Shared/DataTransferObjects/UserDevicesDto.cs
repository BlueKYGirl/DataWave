using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record UserDevicesDto
    {
        public IEnumerable<DeviceDto>? Devices { get; init; }   
    }
}
