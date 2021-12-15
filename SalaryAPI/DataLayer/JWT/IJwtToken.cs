using System;

namespace DataLayer.JWT
{
    public interface IJwtToken
    {
        string GenerateAccessToken(Guid employeeId);
        Guid CreateAuthenticatedUserInfo(string token);
        string GenerateRefreshToken();
        bool ValidateToken(string token);
    }
}
