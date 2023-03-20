namespace Shared.Authorization;

using System.Security.Claims;

public static class ClaimsPrincipalExtensions
{
    public static string? GetEmail(this ClaimsPrincipal principal)
    {
        return principal.FindFirstValue(ClaimTypes.Email);
    }
    
    public static string? GetTenant(this ClaimsPrincipal principal)
    {
        return principal.FindFirstValue(Claims.Tenant);
    }
    
    public static string? GetUserId(this ClaimsPrincipal principal)
        => principal.FindFirstValue(ClaimTypes.NameIdentifier);
    
    private static string? FindFirstValue(this ClaimsPrincipal principal, string claimType)
    {
        return principal is null
            ? throw new ArgumentNullException(nameof(principal))
            : principal.FindFirst(claimType)?.Value;
    }
}