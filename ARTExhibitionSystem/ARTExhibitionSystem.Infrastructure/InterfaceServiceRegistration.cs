using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.Interfaces;
using ARTExhibitionSystem.Infrastructure.Context;
using ARTExhibitionSystem.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ARTExhibitionSystem.Infrastructure
{
    public static class InterfaceServiceRegistration
    {
        public static IServiceCollection AddInterfaceServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Configure DbContext using a connection string from configuration
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ArtExhibitionAPIconnString"));
            });


            // Artwork repository registration (already done)
            services.AddScoped<IArtworkRepository, ArtworkRepository>();



            // Register repositories with their interfaces
            services.AddScoped<IArtworkRepository, ArtworkRepository>();
             services.AddScoped<IArtistRepository, ArtistRepository>();
             services.AddScoped<IUserRepository, UserRepository>();
             services.AddScoped<IGalleryRepository, GalleryRepository>();
             services.AddScoped<IFavoriteArtWorkRepository, FavoriteArtWorkRepository>();
             services.AddScoped<IArtworkGalleryRepository, ArtworkGalleryRepository>();

            return services;
        }
    }
}
    

