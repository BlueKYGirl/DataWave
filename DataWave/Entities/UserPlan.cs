using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserPlan
    {
        [Column("UserPlanId")]
        
        public Guid Id { get; set; }
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        [ForeignKey(nameof(Plan))]
        public Guid PlanId { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }



        
    }
}
