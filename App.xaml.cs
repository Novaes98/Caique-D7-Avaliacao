using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using Caique_D7_avaliacao.Data;

namespace Caique_D7_avaliacao
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider serviceProvider;

        public App()
        {
            ServiceCollection services = new();

            services.AddDbContext<Context>(options =>
            {
                options.UseSqlite("Data source = Register.db");
            });

            services.AddSingleton<MainWindow>();
            serviceProvider = services.BuildServiceProvider();
        }

        private void OnStartup(object s, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

    }
}
