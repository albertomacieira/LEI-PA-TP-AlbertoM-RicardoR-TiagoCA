using Ticket2Help.Models;

namespace Ticket2Help.DAL.Interfaces
{
    /// <summary>
    /// Interface responsável pela definição das operações de acesso a dados para tickets.
    /// </summary>
    public interface ITicketRepository
    {
        /// <summary>
        /// Obtém todos os tickets existentes.
        /// </summary>
        /// <returns>Lista de todos os tickets.</returns>
        IEnumerable<Ticket> GetAll();

        /// <summary>
        /// Obtém um ticket com base no seu identificador.
        /// </summary>
        /// <param name="id">Identificador do ticket.</param>
        /// <returns>O ticket correspondente, ou null se não existir.</returns>
        Ticket? GetById(int id);

        /// <summary>
        /// Adiciona um novo ticket à base de dados.
        /// </summary>
        /// <param name="ticket">O ticket a adicionar.</param>
        void Add(Ticket ticket);

        /// <summary>
        /// Atualiza um ticket existente.
        /// </summary>
        /// <param name="ticket">O ticket com os dados atualizados.</param>
        void Update(Ticket ticket);

        /// <summary>
        /// Remove um ticket com base no seu identificador.
        /// </summary>
        /// <param name="id">Identificador do ticket a remover.</param>
        void Delete(int id);
    }
}
