using System.Windows;
using UI.ViewModels;

namespace UI.Views
{
    public partial class TechnicianDashboardView : Window
    {
        public TechnicianDashboardView()
        {
            InitializeComponent();
            DataContext = new TechnicianDashboardViewModel();
        }
    }
}
