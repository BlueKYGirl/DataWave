using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record PlanDetailDto
    {
        public Guid PlanUserId { get; init; }
        public string? PlanName { get; init; }
        public decimal Price { get; init; }
    }
}