using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Application.Interfaces.Identity;
using ArtExhibitionSystem.Identity.Services;
using ArtExhibitionSystem.Infrastructure.Context;
using ArtExhibitionSystem.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace ArtExhibitionSystem.Infrastructure
{
    public static class InterfaceServiceRegistration
    {
        public static IServiceCollection AddInterfaceServices(this IServiceCollection services, IConfiguration configuration)
        {
            

            services.AddDbContext<ArtDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ArtWebAPIConnString"));


            });
            services.AddScoped<IArtworkRepository, ArtworksRepository>();
            services.AddScoped<IFavoriteArtWorkRepository, FavouriteArtWorkRepository>();
            services.AddScoped<IArtistsRepository, ArtistsRepository>();
            services.AddScoped<IGalleriesRepository, GalleriesRepository>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IArtworkGalleryRepository, ArtWorkGalleryRepository>();

            return services;

        }
    }

}