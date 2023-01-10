
using System.ComponentModel.DataAnnotations;

namespace Prochef.Core.Dtos.Request.Registration
{
    public class LoginEmployeeRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
