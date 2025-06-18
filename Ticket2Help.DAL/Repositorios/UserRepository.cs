using Ticket2Help.Models;
using Ticket2Help.DAL.Interfaces;
using Ticket2Help.DAL.Data;
using System.Linq;

namespace Ticket2Help.DAL.Repositories
{
    /// <summary>
    /// Implementação do repositório de utilizadores.
    /// Responsável pela recuperação de utilizadores da base de dados.
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Construtor que injeta o contexto da base de dados.
        /// </summary>
        /// <param name="context">Contexto da base de dados.</param>
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public User? GetByUsername(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }
    }
}
