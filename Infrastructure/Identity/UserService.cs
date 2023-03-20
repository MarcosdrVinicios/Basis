namespace Infrastructure.Identity;

using Application.Identity.Users;
using Application.Identity.Users.Dto;

internal partial class UserService : IUserService
{
    public Task<bool> ExistsWithNameAsync(string name)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsWithEmailAsync(string email, string? exceptId = null)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsWithPhoneNumberAsync(string phoneNumber, string? exceptId = null)
    {
        throw new NotImplementedException();
    }

    public Task<List<UserDetailsDto>> GetListAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetCountAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<UserDetailsDto> GetAsync(string userId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> HasPermissionAsync(string userId, string permission, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}