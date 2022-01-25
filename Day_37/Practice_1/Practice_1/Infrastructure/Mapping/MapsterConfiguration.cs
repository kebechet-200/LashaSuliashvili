using Mapster;
using Microsoft.Extensions.DependencyInjection;
using PersonService;
using Practice_1.Models.DTOs;

namespace Practice_1.Infrastructure.Mapping
{
    public static class MapsterConfiguration
    {
        public static void MapsRegistration(this IServiceCollection services)
        {
            TypeAdapterConfig<Person, CreatePersonDTO>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<Person, GetPersonDTO>
                .NewConfig()
                .TwoWays();
        }
    }
}
