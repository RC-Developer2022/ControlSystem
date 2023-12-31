using ControlSystem.Infrastructure.Context;
using ControlSystem.Infrastructure.Core.Interfaces;
using ControlSystem.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ControlSystem.Infrastructure;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) 
    {
        services.AddDbContext<SystemContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("Default"))
        );
        services.AddScoped<IPersonPersistence, PersonPersistence>();
        return services;
    }
}
