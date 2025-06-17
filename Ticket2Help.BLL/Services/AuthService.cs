using Ticket2Help.Models;
using Ticket2Help.Utils;

namespace Ticket2Help.BLL.Services
{
    public class AuthService
    {
        private readonly List<User> _users = new()
        {
            new User { Id = 1, Username = "joao", Password = PasswordHasher.HashPassword("1234"), Role = "User" },
            new User { Id = 2, Username = "maria", Password = PasswordHasher.HashPassword("abcd"), Role = "User" },
            new User { Id = 3, Username = "tecnico", Password = PasswordHasher.HashPassword("4321"), Role = "Tecnico" }
        };

        public User? Authenticate(string username, string password)
        {
            string hashedInput = PasswordHasher.HashPassword(password);

            return _users.FirstOrDefault(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)
                && u.Password == hashedInput);
        }
    }
}
