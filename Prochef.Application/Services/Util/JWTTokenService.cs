using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Prochef.Application.Interfaces.Util;
using Prochef.Application.Options;
using Prochef.Core.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Prochef.Application.Services
{
    public class JWTTokenService : IJwtTokenService
    {
        private readonly JWTOptions _JWTOptions;

        public JWTTokenService(IOptions<JWTOptions> JWTOptions)
        {
            _JWTOptions = JWTOptions.Value;
        }

        public JwtSecurityToken CreateJwtToken(Employee identity)
        {
            var now = DateTime.UtcNow;
            var JWTToken = new JwtSecurityToken(
                issuer: _JWTOptions.Issuer,
                audience: _JWTOptions.Audience,
                notBefore: now,
                claims: GetClaims(identity),
                expires: now.Add(TimeSpan.FromMinutes(_JWTOptions.LifeTime)),
                signingCredentials: new SigningCredentials(
                    key: _JWTOptions.GetSymmetricSecurityKey(),
                    algorithm: SecurityAlgorithms.HmacSha256)
            );
            return JWTToken;
        }

        public string EncodeJwtToken(JwtSecurityToken JWTToken) =>
            new JwtSecurityTokenHandler().WriteToken(JWTToken);

        private IEnumerable<Claim> GetClaims(Employee employee)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, employee.Id.ToString()),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, employee.RoleId.ToString()),
            };
            return claims;
        }
    }
}
