using System;
using System.Collections.Generic;
using Ticket2Help.Models;

namespace Ticket2Help.BLL.Interfaces
{
    /// <summary>
    /// Interface responsável pela lógica de negócio relacionada a tickets.
    /// </summary>
    public interface ITicketService
    {
        /// <summary>
        /// Obtém todos os tickets existentes.
        /// </summary>
        /// <returns>Uma coleção de todos os tickets.</returns>
        IEnumerable<Ticket> GetAllTickets();

        /// <summary>
        /// Obtém um ticket pelo seu identificador.
        /// </summary>
        /// <param name="id">O identificador do ticket.</param>
        /// <returns>O ticket correspondente ou null se não encontrado.</returns>
        Ticket? GetTicketById(int id);

        /// <summary>
        /// Cria um novo ticket.
        /// </summary>
        /// <param name="ticket">O ticket a ser criado.</param>
        void CreateTicket(Ticket ticket);

        /// <summary>
        /// Atualiza um ticket existente.
        /// </summary>
        /// <param name="ticket">O ticket com os dados atualizados.</param>
        void UpdateTicket(Ticket ticket);

        /// <summary>
        /// Remove um ticket pelo seu identificador.
        /// </summary>
        /// <param name="id">O identificador do ticket a remover.</param>
        void DeleteTicket(int id);
    }
}
