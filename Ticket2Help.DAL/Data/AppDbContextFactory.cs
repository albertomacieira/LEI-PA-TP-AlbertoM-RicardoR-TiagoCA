using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Ticket2Help.DAL.Data
{
    /// <summary>
    /// Fábrica para criar instâncias de <see cref="AppDbContext"/> em tempo de design.
    /// Necessário para comandos de migração do Entity Framework.
    /// </summary>
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        /// <summary>
        /// Cria uma nova instância de <see cref="AppDbContext"/> com as opções de configuração definidas.
        /// </summary>
        /// <param name="args">Argumentos da linha de comandos (não utilizados).</param>
        /// <returns>Instância configurada de <see cref="AppDbContext"/>.</returns>
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // Connection string usada em tempo de design
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Ticket2HelpDb;Trusted_Connection=True;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
