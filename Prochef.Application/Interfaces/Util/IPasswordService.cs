namespace Prochef.Application.Interfaces.Util
{
    public interface IPasswordService
    {
        string HashPassword(string password);
        bool VerifyHashedPassword(string hashedPassword, string password);
    }
}
