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

namespace UI
{
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;

        public App()
        {
            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(@"Server=localhost;Database=Ticket2HelpDB;Trusted_Connection=True;TrustServerCertificate=true;")
                       .ConfigureWarnings(warnings =>
                           warnings.Ignore(RelationalEventId.PendingModelChangesWarning))
            );

            // Injeção de dependências de views e viewmodels
            services.AddSingleton<LoginView>();
            services.AddSingleton<LoginViewModel>();
            // Adiciona os outros serviços e viewmodels conforme necessário

            serviceProvider = services.BuildServiceProvider();

            // 🔧 Adiciona o evento de arranque da aplicação aqui:
            this.Startup += Application_Startup;
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Executa o seeder para garantir que o admin existe
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                DbInitializer.Seed(context); // chama o seed manualmente
            }

            // Mostra a janela inicial
            var loginView = serviceProvider.GetRequiredService<LoginView>();
            loginView.Show();
        }
    }
}