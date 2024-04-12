using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record SwapPhoneNumberRequestDto
    {
        public DeviceForUpdateDto? Device1 { get; set; }
        public DeviceForUpdateDto? Device2 { get; set; }
    }
   
}