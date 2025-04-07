using ARTExhibitionSystem.Infrastructure.Context;
using ARTExhibitionSystem.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ARTExhibition.Application.Features.ArtworkFeature.Commands;
using ARTExhibition.Application.Interfaces;
using Microsoft.Win32;
using static System.Net.Mime.MediaTypeNames;
using MediatR;
using ARTExhibition.Application.Features.ArtworkFeature.Commands.AddArtwork;
using ARTExhibitionSystem.Infrastructure;
using ARTExhibition.Application;
using ARTExhibitionSystem.Identity;

namespace ARTExhibitionSystem.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Register infrastructure services
            builder.Services.AddInterfaceServices(builder.Configuration);
            builder.Services.AddApplicationServices();

            builder.Services.AddIdentityServices(builder.Configuration);



            // Add CORS policy
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAngular",
                    policy =>
                    {
                        policy.WithOrigins("http://localhost:4200")
                              .AllowAnyHeader()
                              .AllowAnyMethod()
                              .AllowCredentials();
                    });
            });


            // Add services to the container.
            // Add Database Context

            // Register Repositories
            //builder.Services.AddScoped<IArtworkRepository, ArtworkRepository>();
            //builder.Services.AddScoped<IArtistRepository, ArtistRepository>();



            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            // Register MediatR handlers (ensure you pass an assembly that contains your handlers)
            //builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<AddArtworkCommand>());


            // Register application services
            //builder.Services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            //builder.Services.AddScoped<IArtworkRepository, ArtworkRepository>();
            //builder.Services.AddMediatR(typeof(CreateArtworkCommand).Assembly);



            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            // Apply CORS before authentication and authorization
            app.UseCors("AllowAngular");

            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
