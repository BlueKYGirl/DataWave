using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public abstract record UserForManipulationDto
    {
        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(60, ErrorMessage = "First name cannot be longer than 60 characters.")]
        public string? FirstName { get; init; }

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(60, ErrorMessage = "Last name cannot be longer than 60 characters.")]
        public string? LastName { get; init; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; init; }
        [Required(ErrorMessage = "Password is required.")]
        [MaxLength(100, ErrorMessage = "Password cannot be longer than 100 characters.")]
        public string? Password { get; init; }


    }
}
