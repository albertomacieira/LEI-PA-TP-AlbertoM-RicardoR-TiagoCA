using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Media;
using Ticket2Help.Models;

namespace UI.ViewModels
{
    public class EstatisticasDashboardViewModel
    {
        public SeriesCollection TicketSeries { get; set; }

        public EstatisticasDashboardViewModel()
        {
            var tickets = new ObservableCollection<Ticket>
            {
                new Ticket { Titulo = "Login falha", Estado = "Aberto", Descricao = "", DataCriacao = DateTime.Now, UserId = 1, User = new User() },
                new Ticket { Titulo = "Erro página", Estado = "Em Progresso", Descricao = "", DataCriacao = DateTime.Now, UserId = 2, User = new User() },
                new Ticket { Titulo = "Bug crítico", Estado = "Fechado", Descricao = "", DataCriacao = DateTime.Now, UserId = 3, User = new User() },
                new Ticket { Titulo = "Problema sessão", Estado = "Aberto", Descricao = "", DataCriacao = DateTime.Now, UserId = 1, User = new User() }
            };

            var abertos = tickets.Count(t => t.Estado == "Aberto");
            var progresso = tickets.Count(t => t.Estado == "Em Progresso");
            var fechados = tickets.Count(t => t.Estado == "Fechado");

            TicketSeries = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Aberto",
                    Values = new ChartValues<double> { abertos },
                    DataLabels = true,
                    Fill = Brushes.Orange
                },
                new PieSeries
                {
                    Title = "Em Progresso",
                    Values = new ChartValues<double> { progresso },
                    DataLabels = true,
                    Fill = Brushes.SteelBlue
                },
                new PieSeries
                {
                    Title = "Fechado",
                    Values = new ChartValues<double> { fechados },
                    DataLabels = true,
                    Fill = Brushes.SeaGreen
                }
            };
        }
    }
}