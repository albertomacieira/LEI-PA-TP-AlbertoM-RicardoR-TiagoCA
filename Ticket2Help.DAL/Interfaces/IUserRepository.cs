using Ticket2Help.Models;

namespace Ticket2Help.DAL.Interfaces
{
    /// <summary>
    /// Interface responsável pela definição das operações de acesso a dados para utilizadores.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Obtém um utilizador com base no nome de utilizador.
        /// </summary>
        /// <param name="username">Nome de utilizador.</param>
        /// <returns>O utilizador correspondente, ou null se não existir.</returns>
        User? GetByUsername(string username);
    }
}
