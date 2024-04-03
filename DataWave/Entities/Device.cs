using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Device
    {
        [Column("DeviceId")]
        public Guid Id { get; set; }
        public string? PhoneNumber { get; set; }
        [ForeignKey(nameof(User))]
        public Guid? UserId { get; set; }
        public User User { get; set; } = null!;
       
        
    }
}
