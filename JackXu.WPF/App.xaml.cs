using JackXu.WPF.Main.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace JackXu.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public ServiceProvider _serviceProvider { get; set; }
        public App()
        {
            ServiceCollection service = new();
            ConfigServices(service);
            _serviceProvider = service.BuildServiceProvider();


        }
        private static void ConfigServices(ServiceCollection services)
        {
            services.AddSingleton<StartupWindow>();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var startupWindow = _serviceProvider.GetRequiredService<StartupWindow>();
            startupWindow.Show();
        }
    }
}
