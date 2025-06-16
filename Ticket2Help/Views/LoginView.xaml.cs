using System.Windows;
using Ticket2Help.ViewModels;

namespace UI.Views
{
    public partial class LoginView : Window
    {
        private readonly LoginViewModel _viewModel;

        public LoginView()
        {
            InitializeComponent();

            _viewModel = new LoginViewModel();
            this.DataContext = _viewModel;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.Password = PasswordBox.Password; // Lê a password
            _viewModel.Login(this); // Navega se válido
        }
    }
}
