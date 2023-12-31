using ControlSystem.Application.Mapper.Interfaces;
using ControlSystem.Application.Mapper.Services;
using ControlSystem.Application.Repository.Interfaces;
using ControlSystem.Application.Repository.Services;
using ControlSystem.Infrastructure;
using Microsoft.Extensions.Configuration;
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
