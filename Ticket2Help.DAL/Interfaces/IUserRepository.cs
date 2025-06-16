using Ticket2Help.Models;

namespace Ticket2Help.DAL.Interfaces
{
    public interface IUserRepository
    {
        User? GetByUsername(string username);
    }
}
