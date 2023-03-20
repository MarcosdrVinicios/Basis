namespace Infrastructure.Auth.Permissions;

using Shared.Authorization;
using Microsoft.AspNetCore.Authorization;


public class PermissionAttribute : AuthorizeAttribute
{
    public PermissionAttribute(string action, string resource) =>
        Policy = Permission.NameFor(action, resource);
}