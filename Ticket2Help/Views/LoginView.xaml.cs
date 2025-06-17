using System.Windows;
using UI.ViewModels;

namespace UI.View
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
            _viewModel.Username = UsernameBox.Text;
            _viewModel.Password = PasswordBox.Password;
            _viewModel.Login(this);
        }
    }
}
