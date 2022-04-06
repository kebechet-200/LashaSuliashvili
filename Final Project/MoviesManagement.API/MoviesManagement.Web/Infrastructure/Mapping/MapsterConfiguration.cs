using Mapster;
using Microsoft.Extensions.DependencyInjection;
using MoviesManagement.Domain.POCO;
using MoviesManagement.Services.Models;
using MoviesManagement.Web.Models;

namespace MoviesManagement.Web.Infrastructure.Mapping
{
    public static class MapsterConfiguration
    {
        public static void RegisterMaps(this IServiceCollection service)
        {
            TypeAdapterConfig<MovieModel, Movie>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<UserModel, User>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<MovieModel, MovieViewModel>
                .NewConfig()
                .TwoWays();

            //TypeAdapterConfig<AccountRegisterDTO, UserModel>
            //    .NewConfig();

            //TypeAdapterConfig<AccountLoginDTO, UserModel>
            //    .NewConfig();

            TypeAdapterConfig<TicketModel, Ticket>
                .NewConfig();

            TypeAdapterConfig<TicketRequestViewModel, TicketModel>
                .NewConfig();

        }
    }
}
