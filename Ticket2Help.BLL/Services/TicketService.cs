using Ticket2Help.BLL.Interfaces;
using Ticket2Help.DAL.Interfaces;
using Ticket2Help.Models;

namespace Ticket2Help.BLL.Services
{
    /// <summary>
    /// Implementação do serviço de tickets que interage com o repositório de tickets.
    /// </summary>
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        /// <summary>
        /// Construtor que injeta o repositório de tickets.
        /// </summary>
        /// <param name="ticketRepository">Repositório de tickets.</param>
        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        /// <inheritdoc/>
        public IEnumerable<Ticket> GetAllTickets() => _ticketRepository.GetAll();

        /// <inheritdoc/>
        public Ticket? GetTicketById(int id) => _ticketRepository.GetById(id);

        /// <inheritdoc/>
        public void CreateTicket(Ticket ticket) => _ticketRepository.Add(ticket);

        /// <inheritdoc/>
        public void UpdateTicket(Ticket ticket) => _ticketRepository.Update(ticket);

        /// <inheritdoc/>
        public void DeleteTicket(int id) => _ticketRepository.Delete(id);
    }
}
