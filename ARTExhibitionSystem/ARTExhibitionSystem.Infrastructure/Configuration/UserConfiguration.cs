using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibitionSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ARTExhibitionSystem.Infrastructure.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Seed sample users; ensure passwords are stored securely (hashed) in real apps
            builder.HasData(
                new User
                {
                    UserID = 1,
                    Username = "john_doe",
                    Password = "hashedpassword1",
                    Email = "john@example.com",
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(1990, 1, 1)
                },
                new User
                {
                    UserID = 2,
                    Username = "jane_smith",
                    Password = "hashedpassword2",
                    Email = "jane@example.com",
                    FirstName = "Jane",
                    LastName = "Smith",
                    DateOfBirth = new DateTime(1992, 5, 15)
                }
            );
        }
    }
}
