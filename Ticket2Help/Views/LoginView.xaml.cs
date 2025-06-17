using System.Windows;
using Microsoft.EntityFrameworkCore;
using UI.ViewModels;
using Ticket2Help.Utils;
using Ticket2Help.BLL.Services;
using Ticket2Help.DAL.Data;

namespace UI
{
    public partial class LoginView : Window
    {
        private readonly LoginViewModel _viewModel;

        public LoginView()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<AppDbContext>()
                              .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Ticket2HelpDB;Integrated Security=True")
                              .Options;

            var context = new AppDbContext(options);
            var authService = new AuthService(context);
            _viewModel = new LoginViewModel(authService);
            DataContext = _viewModel;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.Username = UsernameBox.Text;
            _viewModel.Password = PasswordBox.Password;
            _viewModel.Login(this);
        }
    }
}

