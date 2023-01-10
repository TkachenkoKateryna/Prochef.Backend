using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Prochef.Core.Entities;

namespace Prochef.Application.Interfaces.Util
{
    public interface IJwtTokenService
    {
        JwtSecurityToken CreateJwtToken(Employee identity);
        string EncodeJwtToken(JwtSecurityToken jwtToken);
    }
}
