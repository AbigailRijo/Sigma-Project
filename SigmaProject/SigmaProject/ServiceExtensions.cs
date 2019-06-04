using BussinessLayer.Services;
using BussinessLayer.Services.Contracts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Data.Models;

namespace SigmaProject.ServiceExtensions
{
    public static class ServiceExtensions
    {
        #region configure cors to acepts request

        public static void ConfigureCords(this IServiceCollection services)
            => services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder => builder
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials()
                        .AllowAnyOrigin());
            });

        #endregion

        #region Swagger Configuration 

        public static void DocumentationSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new Info { Title = "SIGMA API", Description = "" });
                //x.EnableAnnotations();
            });
        }

        #endregion

        #region Configuration service to auth with JWT 

        public static void AuthServiceConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = configuration["Issuer"],
                        ValidAudience = configuration["Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(configuration["SecretKey"])),
                        ClockSkew = TimeSpan.Zero
                    });
        }

        #endregion

        #region configuration to services

        public static void WebServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IBookingService, BookingService>();
            services.AddTransient<IAvailabilityService, AvailabilityService>();
            services.AddTransient<IHotelService, HotelService>();
            services.AddTransient<IRoomService, RoomService>();
            services.AddTransient<IGuestService, GuestService>();
            services.AddTransient<IRoomService, RoomService>();
            services.AddTransient<ITranferService, TranferService>();
        }

        #endregion
    }
}
