using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ARTExhibitionSystem.Identity.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "admin-role-id",  
                    UserId = "admin-user-id"   
                },
                new IdentityUserRole<string>
                {
                    RoleId = "user-role-id",   
                    UserId = "user-user-id"    
                }
            );
        }
    }
}   

