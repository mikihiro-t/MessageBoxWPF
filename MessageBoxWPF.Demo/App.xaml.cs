using System.Configuration;
using System.Data;
using System.Windows;
using MessageBoxWPF.Demo.Service;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace MessageBoxWPF.Demo;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        Ioc.Default.ConfigureServices(
            new ServiceCollection()
            .AddTransient<IDialogService, DialogService>()
            .BuildServiceProvider());

        var mainView = new MainView();
        mainView.Show();

        var mainView2 = new MainWindow();
        mainView2.Show();
    }
}