using System.Net.Sockets;
using Ticket2Help.Models;

namespace Ticket2Help.DAL.Interfaces
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetAll();
        Ticket? GetById(int id);
        void Add(Ticket ticket);
        void Update(Ticket ticket);
        void Delete(int id);
    }
}
