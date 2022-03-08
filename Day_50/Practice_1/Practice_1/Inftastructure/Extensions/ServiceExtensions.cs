using EstateManagement.Inftastructure.Extensions;
using EstateManagement.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;
using Practice_1.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Inftastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IJWTService, JWTService>();
            services.AddScoped<IRealEstateService, RealEstateService>();

            services.AddRepositories();
        }
    }
}
