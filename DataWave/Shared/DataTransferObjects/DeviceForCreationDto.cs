using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record DeviceForCreationDto
    {
        [Required(ErrorMessage = "Phone number is required.")]
        [MaxLength(10, ErrorMessage = "Phone number must be 10 digits.")]
        public string? PhoneNumber { get; init; }
    }
}
