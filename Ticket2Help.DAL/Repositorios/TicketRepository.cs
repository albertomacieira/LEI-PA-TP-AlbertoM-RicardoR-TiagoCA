using System.Collections.Generic;
using System.Linq;
using Ticket2Help.DAL.Data;
using Ticket2Help.Models;
using Ticket2Help.DAL.Interfaces;

namespace Ticket2Help.DAL.Repositories
{
    /// <summary>
    /// Implementação do repositório de tickets.
    /// Responsável pelas operações CRUD relacionadas com tickets na base de dados.
    /// </summary>
    public class TicketRepository : ITicketRepository
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Construtor que injeta o contexto da base de dados.
        /// </summary>
        /// <param name="context">Contexto da base de dados.</param>
        public TicketRepository(AppDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public IEnumerable<Ticket> GetAll()
        {
            return _context.Tickets.ToList();
        }

        /// <inheritdoc/>
        public Ticket? GetById(int id)
        {
            return _context.Tickets.FirstOrDefault(t => t.Id == id);
        }

        /// <inheritdoc/>
        public void Add(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }

        /// <inheritdoc/>
        public void Update(Ticket ticket)
        {
            _context.Tickets.Update(ticket);
            _context.SaveChanges();
        }

        /// <inheritdoc/>
        public void Delete(int id)
        {
            var ticket = _context.Tickets.FirstOrDefault(t => t.Id == id);
            if (ticket != null)
            {
                _context.Tickets.Remove(ticket);
                _context.SaveChanges();
            }
        }
    }
}
