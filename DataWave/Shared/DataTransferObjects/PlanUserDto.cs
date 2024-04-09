using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record PlanUserDto
    {
        public Guid Id { get; init; }
        public Guid PlanId { get; init; }
        public Guid UserId { get; init; }
    }
}
