using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtExhibitionSystem.Identity.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtExhibitionSystem.Identity.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    FirstName = "Admin",
                    LastName = "system",
                    NormalizedUserName = "admin@gmail.com",
                    UserName = "admin@gmail.com",
                    PasswordHash = hasher.HashPassword(null, "Admin@123")
                },


                 new ApplicationUser
                 {
                     Id = "41776062 - 6086 - 1fcf - b923 - 2879a6680b9a",
                     Email = "vaish@gamil.com",
                     NormalizedEmail = "VAISH@GMAIL.COM",
                     FirstName = "vaish",
                     LastName = "patil",
                     NormalizedUserName = "vaish@gamil.com",
                     UserName = "vaish@gamil.com",
                     PasswordHash = hasher.HashPassword(null, "Vaish@123")
                 },



                new ApplicationUser
                {
                    Id = "41776063 - 6086 - 1fcf - b923 - 2879a6680b9a",
                    Email = "patil@gamil.com",
                    NormalizedEmail = "PATIL@GMAIL.COM",
                    FirstName = "rupa",
                    LastName = "patil",
                    NormalizedUserName = "patil@gamil.com",
                    UserName = "patil@gamil.com",
                    PasswordHash = hasher.HashPassword(null, "patil@gamil.com")
                }
            );

        }
    }
}
