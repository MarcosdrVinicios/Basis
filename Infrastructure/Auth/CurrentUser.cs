namespace Infrastructure.Auth;

using Application.Common.Interfaces;
using System.Security.Claims;

public class CurrentUser : ICurrentUser, ICurrentUserInitializer
{
    public string? Name { get; }
    public Guid GetUserId()
    {
        throw new NotImplementedException();
    }

    public string? GetUserEmail()
    {
        throw new NotImplementedException();
    }

    public string? GetTenant()
    {
        throw new NotImplementedException();
    }

    public bool IsAuthenticated()
    {
        throw new NotImplementedException();
    }

    public bool IsInRole(string role)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Claim>? GetUserClaims()
    {
        throw new NotImplementedException();
    }

    public void SetCurrentUser(ClaimsPrincipal principal)
    {
        throw new NotImplementedException();
    }

    public void SetCurrentUserId(string userId)
    {
        throw new NotImplementedException();
    }
}