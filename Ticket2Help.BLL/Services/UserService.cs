using Ticket2Help.BLL.Interfaces;
using Ticket2Help.DAL.Interfaces;
using Ticket2Help.Models;

namespace Ticket2Help.BLL.Services
{
    /// <summary>
    /// Serviço de autenticação de utilizadores com base no repositório.
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        /// <summary>
        /// Construtor que injeta o repositório de utilizadores.
        /// </summary>
        /// <param name="repository">Repositório de utilizadores.</param>
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        /// <inheritdoc/>
        public User? Authenticate(string username, string password)
        {
            var user = _repository.GetByUsername(username);
            if (user != null && user.Password == password)
                return user;

            return null;
        }
    }
}
