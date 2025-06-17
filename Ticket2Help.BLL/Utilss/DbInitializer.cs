using Ticket2Help.DAL.Data;
using Ticket2Help.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Ticket2Help.Utils;


namespace Ticket2Help.BLL.Utilss // <- Nome da pasta correto
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            context.Database.Migrate(); // Aplica migrations pendentes

            // Verifica se já existe um utilizador "admin"
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