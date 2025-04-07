using System.Reflection; 
using Microsoft.Extensions.DependencyInjection;
namespace ArtExhibitionSystem.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection service)
        {
            service.AddMediatR(cfg=>cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            return service;
        }

    }
}
