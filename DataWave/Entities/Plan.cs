using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Plan
    {
        [Column("PlanId")]
        public Guid Id { get; set; }
        public string? PlanName { get; set; }
        public int? DeviceLimit { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

    }
}
