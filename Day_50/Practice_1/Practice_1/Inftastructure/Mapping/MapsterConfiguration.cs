using EstateManagement.Services.Implementations;
using Mapster;
using Microsoft.Extensions.DependencyInjection;
using Practice_1.Models.Request.Account;
using Practice_1.Models.Request.RealEstate;
using Practice_1.Services.Models;
using Practice1.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstateManagement.Inftastructure.Mapping
{
    public static class MapsterConfiguration
    {
        public static void RegisterMaps(this IServiceCollection service)
        {
            TypeAdapterConfig<RealEstate, RealEstateModel>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<Account, AccountModel>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<AccountModel, LoginRequest>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<RealEstateModel, RealEstate>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<CreateRealEstateRequest, RealEstateModel>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<UpdateRealEstateRequest, RealEstateModel>
            .NewConfig()
            .TwoWays();
        }
    }
}
