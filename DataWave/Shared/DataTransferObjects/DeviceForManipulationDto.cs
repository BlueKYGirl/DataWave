using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects
{
    public abstract record DeviceForManipulationDto
    {
        [Required(ErrorMessage = "Phone number is required.")]
        [MaxLength(10, ErrorMessage = "Phone number must be 10 digits.")]
        public string? PhoneNumber { get; init; }
    }
}
