namespace Infrastructure.Persistence.Context;

using Configuration;
using Domain.Models;
using Finbuckle.MultiTenant;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : BaseDbContext
{
    public ApplicationDbContext(ITenantInfo tenantInfo, DbContextOptions options) : base(tenantInfo, options)
    {
    }

    public DbSet<Color> Colors { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.HasDefaultSchema(SchemaNames.Core);
    }
}