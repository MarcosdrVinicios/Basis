namespace Infrastructure.Multitenancy;

using Application.Multitenancy;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using Settings;
using Shared.Multitenancy;

internal static class Startup
{
    internal static IServiceCollection AddMultitenancy(this IServiceCollection services, IConfiguration config)
    {
        return services
            .AddDbContext<TenantDbContext>((p, m) =>
            {
                var databaseSettings = p.GetRequiredService<IOptions<DatabaseSettings>>().Value;
                m.UseSqlServer(databaseSettings.ConnectionString);
                // , e =>
                // e.MigrationsAssembly("Migrators.MSSQL"));
            })
            .AddMultiTenant<TenantInfo>()
            .WithClaimStrategy("tenant")
            .WithHeaderStrategy(MultitenancyConstants.TenantIdName)
            .WithQueryStringStrategy(MultitenancyConstants.TenantIdName)
            .WithEFCoreStore<TenantDbContext, TenantInfo>()
            .Services
            .AddScoped<ITenantService, TenantService>();
    }

    private static FinbuckleMultiTenantBuilder<TenantInfo> WithQueryStringStrategy(
        this FinbuckleMultiTenantBuilder<TenantInfo> builder, string queryStringKey)
    {
        return builder.WithDelegateStrategy(context =>
        {
            if (context is not HttpContext httpContext)
            {
                return Task.FromResult((string?)null);
            }

            httpContext.Request.Query.TryGetValue(queryStringKey, out StringValues tenantIdParam);

            return Task.FromResult((string?)tenantIdParam.ToString());
        });
    }
}