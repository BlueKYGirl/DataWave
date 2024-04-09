using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record PlanDto
    {
        public Guid Id { get; set; }
        public string? PlanName { get; set; }
        public int? DeviceLimit { get; set; }
        public decimal Price { get; set; }
    }
}
