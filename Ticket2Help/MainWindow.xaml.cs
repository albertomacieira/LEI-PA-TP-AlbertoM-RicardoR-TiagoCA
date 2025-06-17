using System.Windows;
using System.Windows.Media;
using Ticket2Help.BLL.Services;

namespace UI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Evento de clique no botão de login
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            if (username == "Username" || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Preencha os dados de login.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MessageBox.Show($"Bem-vindo, {username}!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Placeholder funcional para o TextBox
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.Foreground = Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Username";
                txtUsername.Foreground = Brushes.Gray;
            }
        }
    }
}
