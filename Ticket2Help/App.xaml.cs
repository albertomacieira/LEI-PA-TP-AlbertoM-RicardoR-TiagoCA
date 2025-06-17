using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Ticket2Help.DAL.Data;
using Ticket2Help.BLL.Utilss;
using UI.Views;
using UI.ViewModels;
using UI.View;
using Ticket2Help.BLL.Services;

namespace UI
{
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;

        public App()
        {
            var services = new ServiceCollection();

            // ✅ Registar o AppDbContext com a connection string
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(@"Server=localhost;Database=Ticket2HelpDB;Trusted_Connection=True;TrustServerCertificate=true;")
                       .ConfigureWarnings(warnings =>
                           warnings.Ignore(RelationalEventId.PendingModelChangesWarning)) // ignora aviso se modelo mudou
            );

            // ✅ Registar views e viewmodels
            services.AddSingleton<LoginView>();
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<AuthService>();
            // 👉 Podes adicionar outras views/viewmodels aqui se necessário

            serviceProvider = services.BuildServiceProvider();

            // 👉 Registar evento de arranque
            this.Startup += Application_Startup;
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                // ✅ Aplica migrations e faz seed do admin
                DbInitializer.Seed(context);
            }

            // ✅ Abre o ecrã de login
            var loginView = serviceProvider.GetRequiredService<LoginView>();
            loginView.Show();
        }
    }
}