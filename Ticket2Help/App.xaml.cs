using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Ticket2Help.BLL.Services;
using Ticket2Help.DAL.Data;
using UI.View;

namespace UI
{
    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;

        public App()
        {
            var services = new ServiceCollection();

            string connectionString = "Server=localhost;Database=Ticket2HelpDB;Trusted_Connection=True;TrustServerCertificate=True";
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddTransient<AuthService>();
            services.AddSingleton<LoginView>();

            _serviceProvider = services.BuildServiceProvider();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<LoginView>();
            mainWindow?.Show();
        }
    }
}