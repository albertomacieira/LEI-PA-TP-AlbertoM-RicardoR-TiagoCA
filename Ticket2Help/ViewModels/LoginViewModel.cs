using System.Windows;
using System.Windows.Input;
using Ticket2Help.BLL.Services;
using Ticket2Help.Models;
using UI.Helpers;
using UI.ViewModels;    

namespace UI.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly AuthService _authService;

        public string Username { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand { get; }

        public LoginViewModel(AuthService authService)
        {
            _authService = authService;
            LoginCommand = new RelayCommand(Login);
        }

        private void Login()
        {
            User? user = _authService.Authenticate(Username, Password);
            if (user != null)
            {
                MessageBox.Show($"Bem-vindo, {user.Username} ({user.Role})!", "Login Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                // Redirecionar para a view principal com base no Role...
            }
            else
            {
                MessageBox.Show("Credenciais inválidas!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}