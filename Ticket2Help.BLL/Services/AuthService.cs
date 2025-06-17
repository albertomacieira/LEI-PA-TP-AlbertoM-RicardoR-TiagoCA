using Ticket2Help.Models;
using Ticket2Help.Utils;
using Ticket2Help.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace Ticket2Help.BLL.Services
{
    public class AuthService
    {
        private readonly AppDbContext _context;

        public AuthService(AppDbContext context)
        {
            _context = context;
        }

        public User? Authenticate(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user != null && PasswordHasher.VerifyPassword(password, user.Password))
            {
                return user;
            }

            return null;
        }
    }
}
