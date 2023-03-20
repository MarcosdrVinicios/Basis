namespace Infrastructure.Multitenancy;

using Application.Multitenancy;
using Finbuckle.MultiTenant;
using Microsoft.Extensions.Localization;

internal class TenantService : ITenantService
{
    private readonly IMultiTenantStore<TenantInfo> tenantStore;
    // private readonly IConnectionStringSecurer csSecurer;
    // private readonly IDatabaseInitializer dbInitializer;
    // private readonly IStringLocalizer t;
    // private readonly DatabaseSettings dbSettings;
    public Task<List<TenantDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsWithIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsWithNameAsync(string name)
    {
        throw new NotImplementedException();
    }

    public Task<TenantDto> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<string> ActivateAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<string> DeactivateAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<string> UpdateSubscriptionAsync(string id, DateTime extendedExpiryDate)
    {
        throw new NotImplementedException();
    }
}