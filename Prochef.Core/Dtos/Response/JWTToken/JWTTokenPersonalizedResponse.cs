using System;
using Prochef.Application.Dtos.JWTToken.Base;

namespace Prochef.Application.Dtos.Response.JWTToken
{
    public class JWTTokenPersonifiedResponse : JWTTokenResponse
    {
        public JWTTokenPersonifiedResponse(string accessToken, DateTime expiresAt, string firstName, string middleName, string lastName, int roleId)
            : base(accessToken, expiresAt)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            RoleId = roleId;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int RoleId { get; set; }
    }
}
