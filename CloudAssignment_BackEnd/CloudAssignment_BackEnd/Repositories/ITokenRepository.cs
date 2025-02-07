using Microsoft.AspNetCore.Identity;

namespace CloudAssignment_BackEnd.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, string role);
    }
}
