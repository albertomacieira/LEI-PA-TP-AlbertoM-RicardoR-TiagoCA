using System.Windows;
using Ticket2Help.BLL.Services;
using UI.View;

namespace UI.ViewModels
{
    public class LoginViewModel
    {
        private readonly AuthService _authService;

        public string Username { get; set; }
        public string Password { get; set; }

        public LoginViewModel(AuthService authService)
        {
            _authService = authService;
        }

        public void Login(Window loginWindow)
        {
            var user = _authService.Authenticate(Username, Password);

            if (user != null)
            {
                var dashboardView = new UserDashboardView(); // ← Corrigido: usar a View
                dashboardView.Show();                        // ← Abre a janela
                loginWindow.Close();                         // ← Fecha o login
            }
            else
            {
                MessageBox.Show("Nome de utilizador ou palavra-passe inválidos.",
                                "Erro de Login",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
        }
    }
}