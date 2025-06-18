using System.Collections.ObjectModel;
using Ticket2Help.Models;

namespace UI.ViewModel
{
    /// <summary>
    /// ViewModel para o dashboard do utilizador, contendo dados fictícios para demonstração.
    /// </summary>
    public class UserDashboardViewModel
    {
        /// <summary>
        /// Lista de tickets visíveis no painel.
        /// </summary>
        public ObservableCollection<Ticket> Tickets { get; set; }

        /// <summary>
        /// Inicializa o ViewModel com dados fictícios.
        /// </summary>
        public UserDashboardViewModel()
        {
            Tickets = new ObservableCollection<Ticket>
            {
                new Ticket
                {
                    Id = 1,
                    Titulo = "Problema com login",
                    Descricao = "Não consigo iniciar sessão com as minhas credenciais.",
                    Estado = "Aberto",
                    DataCriacao = DateTime.Now.AddDays(-2),
                    UserId = 1,
                    User = new User { Id = 1, Username = "joao", Password = "123", Role = "User" }
                },
                new Ticket
                {
                    Id = 2,
                    Titulo = "Erro no carregamento da página",
                    Descricao = "A página demora muito tempo a carregar.",
                    Estado = "Em Progresso",
                    DataCriacao = DateTime.Now.AddDays(-1),
                    UserId = 2,
                    User = new User { Id = 2, Username = "maria", Password = "123", Role = "User" }
                },

                new Ticket
                {
                    Id = 3,
                    Titulo = "Problema de Juntas",
                    Descricao = "A página não funciona direiro",
                    Estado = "Fechado",
                    DataCriacao = DateTime.Now.AddDays(-1),
                    UserId = 2,
                    User = new User { Id = 2, Username = "maria", Password = "123", Role = "User" }
                }
            };
        }
    }
}