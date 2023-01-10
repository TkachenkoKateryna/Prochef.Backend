
namespace Prochef.Core.Dtos.Request.Registration
{
    public class RegistrationEmployeeRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int RestaurantId { get; set; }
        public int RoleId { get; set; }
    }
}
