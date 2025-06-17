using System.Windows;
using UI.View;
using UI.Views;

namespace UI.ViewModels
{
    public class LoginViewModel
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        // Torna este método público para que o LoginView.xaml.cs o possa usar
        public void Login(Window loginWindow)
        {
            if (Username == "admin" && Password == "admin")
            {
                var dashboard = new UserDashboardView(); // Substituir conforme necessário
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
