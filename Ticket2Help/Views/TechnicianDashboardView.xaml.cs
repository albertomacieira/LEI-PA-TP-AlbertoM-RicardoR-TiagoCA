using System.Windows;
using UI.ViewModels;

namespace UI.Views
{
    public partial class TechnicianDashboardView : Window
    {
        public TechnicianDashboardView()
        {
            InitializeComponent();

            // Define o DataContext para permitir ligação (binding) ao ViewModel
            DataContext = new TechnicianDashboardViewModel();
        }
    }
}
