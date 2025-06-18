using Ticket2Help.Models;
using Ticket2Help.Utils;
using Ticket2Help.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace Ticket2Help.BLL.Services
{
    /// <summary>
    /// Serviço responsável por autenticação de utilizadores.
    /// </summary>
    public class AuthService
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Construtor que recebe o contexto da base de dados.
        /// </summary>
        /// <param name="context">Instância de AppDbContext.</param>
        public AuthService(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Autentica um utilizador com nome de utilizador e palavra-passe.
        /// </summary>
        /// <param name="username">Nome de utilizador.</param>
        /// <param name="password">Palavra-passe.</param>
        /// <returns>Instância do utilizador autenticado ou null se inválido.</returns>
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
