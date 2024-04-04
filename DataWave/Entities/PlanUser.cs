using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Entities
{
   public class PlanUser
    {
        [Column("PlanUserId")]
        public Guid Id { get; set; }
        [ForeignKey(nameof(Plan))]
        public Guid PlanId { get; set; }
        [ForeignKey(nameof(User))]
        
        public Guid UserId { get; set; }
        public ICollection<Device> Devices { get; } = new List<Device>();
        public Plan Plan { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
