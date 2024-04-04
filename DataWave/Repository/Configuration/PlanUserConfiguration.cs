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
    public class PlanUserConfiguration : IEntityTypeConfiguration<PlanUser>
    {
        public void Configure(EntityTypeBuilder<PlanUser> builder)
        {
           
            builder.HasData (
                
                
                new PlanUser
                {
                    Id = new Guid("c3aa48a0-1dc8-4f17-a6d4-ef57896fe57a"),
                    PlanId = new Guid("f73f65e4-8b79-4fd1-b9a2-cb109ca932e2"),
                    UserId = new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2")
                },
                new PlanUser
                               {
                    Id = new Guid("4fb2f9d1-8746-4850-9e1a-d2b3fc272780"),
                    PlanId = new Guid("b82a50f6-40b8-4b10-b8ef-9f401e3f0ac5"),
                    UserId = new Guid("798acf1b-7339-44bd-8367-7132a978d7b1")
                },
                new PlanUser
                                              {
                    Id = new Guid("8f57b505-4bc2-4cb7-86de-9e8d64dfcf85"),
                    PlanId = new Guid("eaa6bc36-60f3-4815-b19a-8f2b79f4aa67"),
                    UserId = new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb")
                }   
               );
        }
    }
    
    }

