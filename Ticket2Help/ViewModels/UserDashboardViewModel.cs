using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.ViewModels
{
    public class UserDashboardViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Exemplo de uma propriedade ligada ao UI
        private string _boasVindas = "Bem-vindo ao dashboard!";
        public string BoasVindas
        {
            get => _boasVindas;
            set
            {
                if (_boasVindas != value)
                {
                    _boasVindas = value;
                    OnPropertyChanged(nameof(BoasVindas));
                }
            }
        }
    }
}