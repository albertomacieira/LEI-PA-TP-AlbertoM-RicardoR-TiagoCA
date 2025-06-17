using System.Windows;
using Ticket2Help.BLL.Services;
using Ticket2Help.Models;
using UI.Views;

namespace UI.ViewModels
{
    public class LoginViewModel
    {
        private readonly AuthService _authService = new(); // Serviço de autenticação

        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public void Login(Window loginWindow)
        {
            User? user = _authService.Authenticate(Username, Password);

            if (user != null)
            {
                Window dashboard;

                if (user.Role == "Tecnico")
                {
                    dashboard = new TechnicianDashboardView();
                }
                else // "User" ou outros
                {
                    dashboard = new UserDashboardView();
                }

                dashboard.Show();
                loginWindow.Close();
            }
            else
            {
                MessageBox.Show("Credenciais inválidas. Tente novamente.");
            }
        }
    }
}
