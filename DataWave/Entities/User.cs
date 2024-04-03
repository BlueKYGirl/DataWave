using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class User
     {
        [Column("UserId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(60, ErrorMessage = "First name cannot be longer than 60 characters.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(60, ErrorMessage = "Last name cannot be longer than 60 characters.")]
        public string? LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public List<Plan> Plans { get; } = [];
        public ICollection<Device> Devices { get; } = new List<Device>();


        public string? FullName
        {
            get

            {
                return LastName + ", " + FirstName;
            }
        }

    }
}
