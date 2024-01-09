using ControlSystem.Application.Core.Mapper.Interfaces;
using ControlSystem.Application.Core.Mapper.Services;
using ControlSystem.Application.Repository.Interfaces;
using ControlSystem.Application.Repository.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ControlSystem.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IMapperPerson, MapperPerson>();
        services.AddScoped<IPersonService, PersonService>();
        return services;
    }
}
