using Microsoft.EntityFrameworkCore;
using Ticket2Help.Models;

namespace Ticket2Help.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relação 1:N entre User e Ticket
            modelBuilder.Entity<User>()
                .HasMany(u => u.Tickets)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId);

            // Seed de dados com senhas pré-hashadas
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

