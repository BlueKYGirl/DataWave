using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record SwapPhoneNumberResponseDto
    {
        public DeviceDto? Device1 { get; set; }
        public DeviceDto? Device2 { get; set; }
    }
}
