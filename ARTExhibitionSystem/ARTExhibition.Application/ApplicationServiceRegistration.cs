using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibition.Application.Features.ArtworkFeature.Commands.AddArtwork;
using Microsoft.Extensions.DependencyInjection;

namespace ARTExhibition.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<AddArtworkCommand>());
            return services;
        }
    }
}
