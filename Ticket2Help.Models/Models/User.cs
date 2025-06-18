using System.Collections.Generic;

namespace Ticket2Help.Models
{
    /// <summary>
    /// Representa um utilizador do sistema.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Identificador único do utilizador.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome de utilizador utilizado para login.
        /// </summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Palavra-passe do utilizador (armazenada de forma segura).
        /// </summary>
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// Função do utilizador no sistema (ex: "User" ou "Tecnico").
        /// </summary>
        public string Role { get; set; } = "User";

        /// <summary>
        /// Lista de tickets submetidos por este utilizador.
        /// </summary>
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
