using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using Avalonia_TestManagerForBKStudia.Infrastructure.Extensions;
using Avalonia_TestManagerForBKStudia.ViewModels;
using Avalonia_TestManagerForBKStudia.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Avalonia_TestManagerForBKStudia;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        BindingPlugins.DataValidators.RemoveAt(0);

        

        IServiceCollection collection = new ServiceCollection();
        collection.BuildProvider();

        var services = collection.BuildServiceProvider();

        var vm = services.GetRequiredService<MainWindowViewModel>();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = vm
            };
        }

        base.OnFrameworkInitializationCompleted();
    }


}


