using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Repository.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                    FirstName = "Carson",
                    LastName = "Alexander",
                    Email = "calexander@contosouniversity.edu",
                },
                new User
                {
                    Id = new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                    FirstName = "Meredith",
                    LastName = "Alonso",
                    Email = "malonso@contosouniversity.edu",
                },
                new User
                {
                    Id = new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                    FirstName = "Arturo",
                    LastName = "Anand",
                    Email = "aanand@contosouniversity.edu",
                }
                // Add other users here
            );
        }
    }
}

        
