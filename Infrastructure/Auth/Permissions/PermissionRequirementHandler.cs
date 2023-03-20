namespace Infrastructure.Auth.Permissions;

using Application.Identity.Users;
using Microsoft.AspNetCore.Authorization;
using Shared.Authorization;

internal class PermissionRequirementHandler : AuthorizationHandler<PermissionRequirement>
{
    private readonly IUserService userService;

    public PermissionRequirementHandler(IUserService userService)
    {
        this.userService = userService;
    }

    protected override async Task HandleRequirementAsync(
        AuthorizationHandlerContext context,
        PermissionRequirement requirement)
    {
        if (context.User?.GetUserId() is { } userId &&
            await userService.HasPermissionAsync(userId, requirement.Permission))
        {
            context.Succeed(requirement);
        }
    }
}