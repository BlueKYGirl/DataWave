using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
           builder.HasData(
                     new Plan
                     {
                         Id = new Guid("f73f65e4-8b79-4fd1-b9a2-cb109ca932e2"),
                         DeviceLimit = 10,
                         PlanName = "Basic Plan",
                         Price = 29.99m
                     },
                new Plan
                {
                    Id = new Guid("b82a50f6-40b8-4b10-b8ef-9f401e3f0ac5"),
                    DeviceLimit = 20,
                    PlanName = "Premium Plan",
                    Price = 49.99m
                },
                new Plan
                {
                    Id = new Guid("eaa6bc36-60f3-4815-b19a-8f2b79f4aa67"),
                    DeviceLimit = 3,
                    PlanName = "Free Plan",
                    Price = 0m
                });
        }
    }
}
