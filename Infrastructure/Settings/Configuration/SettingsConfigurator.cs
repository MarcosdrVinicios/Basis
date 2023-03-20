namespace Infrastructure.Settings.Configuration;

using Microsoft.Extensions.DependencyInjection;

public static class SettingsConfigurator
{
    public static IServiceCollection AddSettings(this IServiceCollection services)
    {
        return services;
    }
}