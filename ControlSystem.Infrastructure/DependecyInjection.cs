using ControlSystem.Infrastructure.Context;
using ControlSystem.Infrastructure.Core.Interfaces;
using ControlSystem.Infrastructure.Core.Interfaces.Base;
using ControlSystem.Infrastructure.Services;
using ControlSystem.Infrastructure.Services.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ControlSystem.Infrastructure;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) 
    {
        services.AddDbContext<SystemContext>(options =>
            options
            .UseNpgsql(configuration.GetConnectionString("Default"))
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
        );
        services.AddScoped<IPersonPersistence, PersonPersistence>();
        services.AddScoped(typeof(IGeneralPersistence<>), typeof(GeneralPersistence<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}
