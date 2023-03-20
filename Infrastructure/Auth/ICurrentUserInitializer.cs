namespace Infrastructure.Auth;

using System.Security.Claims;

public interface ICurrentUserInitializer
{
    void SetCurrentUser(ClaimsPrincipal principal);
    void SetCurrentUserId(string userId);
}