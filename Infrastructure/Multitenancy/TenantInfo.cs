namespace Infrastructure.Multitenancy;

using Finbuckle.MultiTenant;
using Shared.Multitenancy;

public class TenantInfo : ITenantInfo
{
    /// <summary>
    /// The actual TenantId, which is also used in the TenantId shadow property on the multitenant entities.
    /// </summary>
    public string Id { get; set; } = default!;

    /// <summary>
    /// The identifier that is used in headers/routes/querystrings. This is set to the same as Id to avoid confusion.
    /// </summary>
    public string Identifier { get; set; } = default!;

    public string Name { get; set; } = default!;
    public string ConnectionString { get; set; } = default!;

    public string AdminEmail { get; private set; } = default!;
    public bool IsActive { get; private set; }
    public DateTimeOffset ValidUpto { get; private set; }
    
    public void AddValidity(int months) =>
        ValidUpto = ValidUpto.AddMonths(months);

    public void SetValidity(in DateTime validTill) =>
        ValidUpto = ValidUpto < validTill
            ? validTill
            : throw new Exception("Subscription cannot be backdated.");

    public void Activate()
    {
        if (Id == MultitenancyConstants.Root.Id)
        {
            throw new InvalidOperationException("Invalid Tenant");
        }

        IsActive = true;
    }

    public void Deactivate()
    {
        if (Id == MultitenancyConstants.Root.Id)
        {
            throw new InvalidOperationException("Invalid Tenant");
        }

        IsActive = false;
    }

    string? ITenantInfo.Id { get => Id; set => Id = value ?? throw new InvalidOperationException("Id can't be null."); }
    string? ITenantInfo.Identifier { get => Identifier; set => Identifier = value ?? throw new InvalidOperationException("Identifier can't be null."); }
    string? ITenantInfo.Name { get => Name; set => Name = value ?? throw new InvalidOperationException("Name can't be null."); }
    string? ITenantInfo.ConnectionString { get => ConnectionString; set => ConnectionString = value ?? throw new InvalidOperationException("ConnectionString can't be null."); }
}