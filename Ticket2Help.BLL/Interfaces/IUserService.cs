using Ticket2Help.Models;

namespace Ticket2Help.BLL.Interfaces
{
    public interface IUserService
    {
        User? Authenticate(string username, string password);
    }
}
