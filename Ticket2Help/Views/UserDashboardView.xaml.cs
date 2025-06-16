using System.ComponentModel;
using System.Windows;

namespace UI.Views
{
    public partial class UserDashboardView : Window
    {
        public UserDashboardView()
        {
            InitializeComponent();

            // Só define o DataContext se não estiver em modo designer
            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                DataContext = new ViewModels.UserDashboardViewModel();
            }
        }
    }
}
