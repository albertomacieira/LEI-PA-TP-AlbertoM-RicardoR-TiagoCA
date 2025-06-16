using Ticket2Help.BLL.Interfaces;
using Ticket2Help.DAL.Interfaces;
using Ticket2Help.Models;

namespace Ticket2Help.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public User? Authenticate(string username, string password)
        {
            var user = _repository.GetByUsername(username);
            if (user != null && user.Password == password)
                return user;

            return null;
        }
    }
}
