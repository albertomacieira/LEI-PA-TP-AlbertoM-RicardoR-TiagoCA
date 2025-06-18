using Ticket2Help.DAL.Data;
using Ticket2Help.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Ticket2Help.Utils;

namespace Ticket2Help.BLL.Utilss
{
    /// <summary>
    /// Classe utilitária responsável por iniciar a base de dados com dados padrão.
    /// </summary>
    public static class DbInitializer
    {
        /// <summary>
        /// Aplica as migrações pendentes e insere um user admin padrão se ainda não existir.
        /// </summary>
        /// <param name="context">Contexto da base de dados.</param>
        public static void Seed(AppDbContext context)
        {
            // Aplica todas as migrations pendentes
            context.Database.Migrate();

            // Verifica se já existe um utilizador com username "admin"
            if (!context.Users.Any(u => u.Username == "admin"))
            {
                var admin = new User
                {
                    Username = "admin",
                    Password = PasswordHasher.HashPassword("admin123"),
                    Role = "Admin"
                };

                context.Users.Add(admin);
                context.SaveChanges();
            }
        }
    }
}
