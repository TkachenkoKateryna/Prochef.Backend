using System;
using System.Collections.Generic;
using System.Text;

namespace Prochef.Application.Dtos.JWTToken.Base
{
    public abstract class JWTTokenResponse
    {
        public JWTTokenResponse(string accessToken, DateTime expiresAt)
        {
            AccessToken = accessToken;
            ExpiresAt = expiresAt;
        }

        public string AccessToken { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}
