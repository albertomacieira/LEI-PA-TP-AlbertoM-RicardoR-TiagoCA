using System.ComponentModel;
using System.Windows.Input;
using UI.Helpers;

namespace UI.ViewModels
{
    public class TechnicianDashboardViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Comandos
        public ICommand VerTicketsCommand { get; }

        public TechnicianDashboardViewModel()
        {
            VerTicketsCommand = new RelayCommand(ExecutarVerTickets);
        }

        private void ExecutarVerTickets(object? obj)
        {
            System.Windows.MessageBox.Show("Botão 'Ver Tickets Pendentes' clicado!");
        }
    }
}
