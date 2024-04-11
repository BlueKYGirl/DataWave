using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record PlanUserForCreationDto
    {
        public Guid PlanId {get; init; }
        public Guid UserId {get; init; }
    }
}
