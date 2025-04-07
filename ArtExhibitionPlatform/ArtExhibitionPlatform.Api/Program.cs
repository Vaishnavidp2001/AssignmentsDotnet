//using Microsoft.EntityFrameworkCore;
//using ArtexibitionPlatform.Infrastructure.Context;
//namespace ArtExhibitionPlatform.Api
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var builder = WebApplication.CreateBuilder(args);

//            // Add services to the container.

//            builder.Services.AddControllers();

//            builder.Services.AddDbContext<ArtExhibitionDbContext>(options =>
//                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
//            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//            builder.Services.AddEndpointsApiExplorer();
//            builder.Services.AddSwaggerGen();

//            var app = builder.Build();

//            // Configure the HTTP request pipeline.
//            if (app.Environment.IsDevelopment())
//            {
//                app.UseSwagger();
//                app.UseSwaggerUI();
//            }

//            app.UseHttpsRedirection();

//            app.UseAuthorization();


//            app.MapControllers();

//            app.Run();
//        }
//    }
//}


//using ArtexibitionPlatform.Infrastructure.Context;
//using Microsoft.EntityFrameworkCore;
//using ArtExhibitionPlatform.Infrastructure.Repository;
//using ArtExhibitionPlatform.Application.Interface;  // Fix Interface Namespace
//using ArtExhibitionPlatform.Application.Service;    // Fix Service Namespace


//namespace ArtExhibitionPlatform.Api
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var builder = WebApplication.CreateBuilder(args);

//            // Access Configuration from builder
//            var configuration = builder.Configuration;

//            // Add services to the container
//            builder.Services.AddControllers();

//            // Configure Entity Framework Core
//            builder.Services.AddDbContext<ArtExhibitionDbContext>(options =>
//                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

//            // ✅ Register Repositories (Infrastructure Layer)
//            builder.Services.AddScoped<Infrastructure.Repository.IUserRepository, UserRepository>();


//            // ✅ Register Services (Application Layer)
//            builder.Services.AddScoped<IUserService, UserService>();


//            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//            builder.Services.AddEndpointsApiExplorer();
//            builder.Services.AddSwaggerGen();

//            var app = builder.Build();

//            // Configure the HTTP request pipeline
//            if (app.Environment.IsDevelopment())
//            {
//                app.UseSwagger();
//                app.UseSwaggerUI();
//            }

//            app.UseHttpsRedirection();
//            app.UseAuthorization();
//            app.MapControllers();

//            app.Run();
//        }
//    }
//}




using ArtExhibitionPlatform.Application.Interface.Service;
using ArtExhibitionPlatform.Infrastructure.Context;
using ArtExhibitionPlatform.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace ArtExhibitionPlatform.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;

            builder.Services.AddControllers();

            // Configure Entity Framework Core
            builder.Services.AddDbContext<ArtExhibitionDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // ✅ Register Repositories (Infrastructure Layer)
            builder.Services.AddScoped<IUserRepository, UserRepository>();

            // ✅ Register Services (Application Layer)
            builder.Services.AddScoped<IUserService, UserService>();


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
