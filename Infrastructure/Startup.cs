namespace Infrastructure;

using Auth;
using Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Multitenancy;
using Persistence;

public static class Startup
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        return services
            .AddAuth(config)
            .AddPersistence(config)
            .AddMultitenancy(config)
            .AddServices();
    }
}