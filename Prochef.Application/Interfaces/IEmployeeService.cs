
using Prochef.Application.Dtos.Response.JWTToken;

using Prochef.Core.Dtos.Request.Registration;

namespace Prochef.Application.Interfaces
{
    public interface IEmployeeService
    {
        void RegisterEmployee(RegistrationEmployeeRequest registrationRequest);
        JWTTokenEmployeeResponse LoginEmployee(LoginEmployeeRequest loginRequest);
    }
}
