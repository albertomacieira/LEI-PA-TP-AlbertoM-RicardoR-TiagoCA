using Ticket2Help.Models;

namespace Ticket2Help.BLL.Interfaces
{
    /// <summary>
    /// Interface para autenticação e serviços relacionados ao utilizador.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Autentica um utilizador com base no nome de utilizador e palavra-passe.
        /// </summary>
        /// <param name="username">O nome de utilizador.</param>
        /// <param name="password">A palavra-passe.</param>
        /// <returns>O utilizador autenticado ou null se falhar a autenticação.</returns>
        User? Authenticate(string username, string password);
    }
}
