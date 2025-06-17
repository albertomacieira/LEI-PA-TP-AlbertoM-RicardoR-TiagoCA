using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ticket2Help.DAL.Data;
using UI.Views;
using UI.View;
using UI.ViewModels;

namespace UI
{
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;

        public App()
        {
            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Server=localhost;Database=Ticket2HelpDb;Trusted_Connection=True;"));

            services.AddSingleton<LoginView>();
            // Add outros ViewModels, serviços, etc...

            serviceProvider = services.BuildServiceProvider();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var loginView = serviceProvider.GetRequiredService<LoginView>();
            loginView.Show();
        }
    }
}
