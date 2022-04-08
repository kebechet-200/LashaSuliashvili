﻿using Mapster;
using Microsoft.Extensions.DependencyInjection;
using MoviesManagement.Admin.Models;
using MoviesManagement.Domain.POCO;
using MoviesManagement.Services.Models;

namespace MoviesManagement.Admin.Infrastructure.Mapping
{
    public static class MapsterConfiguration
    {
        public static void RegisterMaps(this IServiceCollection services)
        {
            //TypeAdapterConfig<MovieModel, Movie>
            //    .NewConfig()
            //    .TwoWays();

            TypeAdapterConfig<UserModel, User>
                .NewConfig()
                .TwoWays();

            //TypeAdapterConfig<MovieModel, MovieViewModel>
            //    .NewConfig()
            //    .TwoWays();

            TypeAdapterConfig<LoginViewModel, UserModel>
                .NewConfig();

            //TypeAdapterConfig<TicketModel, Ticket>
            //    .NewConfig();

            //TypeAdapterConfig<TicketRequestViewModel, TicketModel>
            //    .NewConfig();
        }
    }
}
