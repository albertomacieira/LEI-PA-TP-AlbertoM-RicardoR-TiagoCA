using System.Windows;
using System.Windows.Input;
using Ticket2Help.DAL.Data;
using UI.Views;
using Ticket2Help.Models;

namespace UI.ViewModels
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand => new RelayCommand(Login);

        private void Login()
        {
            using (var context = new AppDbContextFactory().CreateDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == Username && u.Password == Password);

                if (user != null)
                {
                    if (user.Role == "Technician")
                        new TechnicianDashboardView().Show();
                    else
                        new UserDashboardView().Show();

                    CloseLoginWindow();
                }
                else
                {
                    MessageBox.Show("Credenciais inválidas.");
                }
            }
        }

        private void CloseLoginWindow()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window is LoginView)
                {
                    window.Close();
                    break;
                }
            }
        }
    }
}
