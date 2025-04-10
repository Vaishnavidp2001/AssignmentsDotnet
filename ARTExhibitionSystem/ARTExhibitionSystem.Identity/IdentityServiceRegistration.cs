﻿using ARTExhibitionSystem.Identity.Model;
using Microsoft.Extensions.DependencyInjection;
using ARTExhibitionSystem.Identity.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ARTExhibitionSystem.Identity.Services;
using ARTExhibition.Application.Interfaces;



namespace ARTExhibitionSystem.Identity
{
    public static class IdentityServiceRegistration
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Connection String Key
            services.AddDbContext<ArtExhibitionIdentityDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ArtExhibitionAPIconnString")));

            // Identity Configuration
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ArtExhibitionIdentityDbContext>()
                .AddDefaultTokenProviders();

            //Register AuthService
            services.AddTransient<ITokenService, TokenService>();

            // Corrected JwtSettings References
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidIssuer = configuration["Jwt:Issuer"],       
                    ValidAudience = configuration["Jwt:Audience"],   
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])) 
                };
            });

            return services;
        }
    }
}
