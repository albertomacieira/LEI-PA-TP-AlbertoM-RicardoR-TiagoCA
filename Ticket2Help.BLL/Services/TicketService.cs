using Ticket2Help.BLL.Interfaces;
using Ticket2Help.DAL.Interfaces;
using Ticket2Help.Models;

namespace Ticket2Help.BLL.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public IEnumerable<Ticket> GetAllTickets() => _ticketRepository.GetAll();

        // Agora explicitamente pode retornar null
        public Ticket? GetTicketById(int id) => _ticketRepository.GetById(id);

        public void CreateTicket(Ticket ticket) => _ticketRepository.Add(ticket);

        public void UpdateTicket(Ticket ticket) => _ticketRepository.Update(ticket);

        public void DeleteTicket(int id) => _ticketRepository.Delete(id);
    }
}
