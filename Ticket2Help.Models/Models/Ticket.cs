using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket2Help.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public required string Titulo { get; set; }

        public required string Descricao { get; set; }

        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public string Estado { get; set; } = "Aberto"; // Ex: Aberto, Em Progresso, Resolvido

        public int UserId { get; set; }
        public required User User { get; set; }
    }
}
