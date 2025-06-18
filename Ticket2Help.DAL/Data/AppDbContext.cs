using Microsoft.EntityFrameworkCore;
using Ticket2Help.Models;

namespace Ticket2Help.DAL.Data
{
    /// <summary>
    /// Representa o contexto da base de dados da aplicação.
    /// Contém os DbSets para as entidades e configurações do modelo.
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Construtor que recebe opções de configuração para o contexto.
        /// </summary>
        /// <param name="options">Opções de configuração do contexto.</param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        /// <summary>
        /// Tabela de utilizadores.
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Tabela de pedidos/tickets.
        /// </summary>
        public DbSet<Ticket> Tickets { get; set; }

        /// <summary>
        /// Configura as relações entre entidades e insere dados iniciais.
        /// </summary>
        /// <param name="modelBuilder">Construtor do modelo da base de dados.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relação 1:N entre Utilizador e Ticket
            modelBuilder.Entity<User>()
                .HasMany(u => u.Tickets)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId);

            // Inserção de utilizadores de teste com palavras-passe já cifradas
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "joao",
                    Password = "0nHVBgzAqTc=:5PvRrbWxMQiCUJ3KRaQnFHQITgzZsEiQ1gC74sV6M3I=",
                    Role = "User"
                },
                new User
                {
                    Id = 2,
                    Username = "maria",
                    Password = "fMNR7sWD3no=:hLb5tqjyrXCrTwAmKCS51rCrD8AD9KznOX3kW9JdS+I=",
                    Role = "User"
                },
                new User
                {
                    Id = 3,
                    Username = "tecnico",
                    Password = "ToK23QYbnW4=:vdwhOqlnkUkKGeY7NsMa1pKj+N7ml8DAjFqlb6KUPLY=",
                    Role = "Tecnico"
                }
            );
        }
    }
}
