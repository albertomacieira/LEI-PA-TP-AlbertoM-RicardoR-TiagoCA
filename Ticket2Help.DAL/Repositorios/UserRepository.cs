using Ticket2Help.Models;
using Ticket2Help.DAL.Interfaces;
using Ticket2Help.DAL.Data;
using System.Linq;

namespace Ticket2Help.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User? GetByUsername(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }
    }
}
