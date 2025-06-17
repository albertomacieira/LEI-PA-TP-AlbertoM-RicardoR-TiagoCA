using Ticket2Help.Models;
using System.Collections.Generic;


namespace Ticket2Help.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = "User"; // ou "Tecnico"

        public required ICollection<Ticket> Tickets
        {
            get; set;
        }

    }
}
