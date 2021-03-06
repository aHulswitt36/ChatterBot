﻿using ChatterBot.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Windows;

namespace ChatterBot
{
    public partial class App
    {
        private readonly IHost _host;

        public App()
        {
            _host = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<MainViewModel>();
                    services.AddSingleton<AccountsViewModel>();
                    services.AddSingleton<AccountsWindow>();
                    services.AddSingleton<MainWindow>();
                })
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                    logging.AddDebug();
                })
                .Build();

        }

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _host.Services.GetService<MainWindow>();
            Current.MainWindow = mainWindow; // TODO: Confirm if this adds any benefit.
            mainWindow.Show();
        }
    }
}
