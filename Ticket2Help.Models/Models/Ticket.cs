using System;

namespace Ticket2Help.Models
{
    /// <summary>
    /// Representa um ticket de suporte submetido por um utilizador.
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Identificador único do ticket.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Título do ticket que resume o problema ou pedido.
        /// </summary>
        public required string Titulo { get; set; }

        /// <summary>
        /// Descrição detalhada do problema ou questão colocada pelo utilizador.
        /// </summary>
        public required string Descricao { get; set; }

        /// <summary>
        /// Data e hora de criação do ticket.
        /// Por defeito é a data atual.
        /// </summary>
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        /// <summary>
        /// Estado atual do ticket (por exemplo: "Aberto", "Em Progresso", "Resolvido").
        /// </summary>
        public string Estado { get; set; } = "Aberto";

        /// <summary>
        /// Identificador do utilizador que criou o ticket.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Referência para o utilizador associado a este ticket.
        /// </summary>
        public required User User { get; set; }
    }
}
