using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia_TestManagerForBKStudia.ViewModels;
using Avalonia_TestManagerForBKStudia.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Avalonia_TestManagerForBKStudia;

public partial class App : Application
{
    private readonly IServiceProvider _service;
    public App(IServiceProvider service)
    {
        _service = service;
    }
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = _service.GetRequiredService<MainWindowViewModel>()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}


