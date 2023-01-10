using System;


namespace Prochef.Application.Dtos.Response.JWTToken
{
    public class JWTTokenEmployeeResponse : JWTTokenPersonifiedResponse
    {
        public JWTTokenEmployeeResponse
        (
            string accessToken,
            DateTime expiresAt,
            string firstName,
            string middleName,
            string lastName,
            int roleId
        ) : base(accessToken, expiresAt, firstName, middleName, lastName, roleId)
        {
        }
    }
}
