using JackXu.WPF.Main.Views;
using JackXu.WPF.Task.Models;
using JackXu.WPF.Task.ViewModels;
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
        public static IServiceProvider ServiceProvider { get; set; }
        public App()
        {
            ServiceCollection service = new();
            ConfigServices(service);
            ServiceProvider = service.BuildServiceProvider();


        }
        private static void ConfigServices(ServiceCollection services)
        {
            services.AddSingleton<StartupWindow>();
            services.AddScoped<CustomerInvoiceViewModel>();
            
            services.AddSingleton<IPayment>(s=> new Payment("GTBank"));
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var startupWindow = ServiceProvider.GetRequiredService<StartupWindow>();
            startupWindow.Show();
        }
    }
}
