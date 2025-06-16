using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ticket2Help.BLL.Interfaces
{
    using Ticket2Help.Models;

    public interface ITicketService
    {
        IEnumerable<Ticket> GetAllTickets();
        Ticket GetTicketById(int id);
        void CreateTicket(Ticket ticket);
        void UpdateTicket(Ticket ticket);
        void DeleteTicket(int id);
    }
}
