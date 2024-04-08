using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record DeviceDto
    {
        public Guid Id { get; init; }
        public string? PhoneNumber { get; init; }
        public Guid? UserId { get; init; }
       
    }
}
