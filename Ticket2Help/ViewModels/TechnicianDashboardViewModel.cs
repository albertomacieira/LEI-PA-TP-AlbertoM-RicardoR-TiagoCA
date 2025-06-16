using System;
using System.ComponentModel;
using System.Windows.Input;
using UI.Helpers;

namespace UI.ViewModels
{
    public class TechnicianDashboardViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        // Comando que será ligado ao botão
        public ICommand VerTicketsCommand { get; }

        public TechnicianDashboardViewModel()
        {
            // Inicialização do comando com o método a executar
            VerTicketsCommand = new RelayCommand(ExecutarVerTickets);
        }

        private void ExecutarVerTickets(object obj)
        {
            // Lógica ao clicar no botão
            System.Windows.MessageBox.Show("Botão 'Ver Tickets' clicado!");
        }
    }
}
