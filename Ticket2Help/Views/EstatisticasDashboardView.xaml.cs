using System.Windows;
using UI.ViewModels;

namespace UI.View
{
    /// <summary>
    /// Interaction logic for EstatisticasDashboardView.xaml
    /// </summary>
    public partial class EstatisticasDashboardView : Window
    {
        public EstatisticasDashboardView()
        {
            InitializeComponent();

            // Opcional: Define explicitamente o DataContext, se quiseres fazer tudo no code-behind
            // this.DataContext = new EstatisticasDashboardViewModel();
        }
    }
}