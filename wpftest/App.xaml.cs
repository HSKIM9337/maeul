using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using wpftest.ViewModels;

namespace wpftest
{
    public partial class App : Application
    {
        public App()
        {
            Services = ConfigureServices();
            this.InitializeComponent();
        }
        public new static App Current => (App)Application.Current;

        public IServiceProvider Services { get; }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient(typeof(MainWindowViewModel));
            services.AddSingleton(typeof(DashBoardViewModel));
            services.AddSingleton(typeof(HeaderViewModel));
            services.AddSingleton(typeof(SignUpViewModel));

            return services.BuildServiceProvider();
        }
    }
}
