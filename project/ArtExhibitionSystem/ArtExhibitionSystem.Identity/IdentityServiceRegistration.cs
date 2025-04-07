using ArtExhibitionSystem.Identity.Context;
using ArtExhibitionSystem.Identity.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ArtExhibitionSystem.Identity
{
    public static class IdentityServiceRegistration
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ArtAppIdentityDbContext>(options =>

                options.UseSqlServer(configuration.GetConnectionString("ArtWebAPIConnString")));
            services.AddIdentity<ApplicationUser, IdentityRole>().
            AddEntityFrameworkStores <ArtAppIdentityDbContext>().AddDefaultTokenProviders();




            return services;
        }
    }
}
