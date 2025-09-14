using System;
using System.Threading.Tasks;
using Avalonia;
using Avalonia_TestManagerForBKStudia.Infrastructure.Constants;
using Avalonia_TestManagerForBKStudia.Infrastructure.Extensions;
using Avalonia_TestManagerForBKStudia.Infrastructure.TestDirectory;
using Avalonia_TestManagerForBKStudia.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Avalonia_TestManagerForBKStudia;

sealed class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static async Task Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder();

        builder.Logging.ClearProviders();
        builder.Configuration.AddJsonFile("appsettings.json");

        builder.Services.AddServices();
        builder.Services.AddDirectory(builder.Configuration);

        DirectoryConstants.TestsDirectoryPath = builder
            .Configuration[DirectoryConstants.TEST_DIRECTORY_KEY]!;

        var app = builder.Build();

        
        var testDirectory = app.Services.GetRequiredService<TestDirectoryInitializer>();
        testDirectory.Initialize();
        app.Services.GetRequiredService<MainWindowViewModel>();

        await app.StartAsync();

        BuildAvaloniaApp(app.Services)
            .StartWithClassicDesktopLifetime(args);

        await app.StopAsync();
    }

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp(IServiceProvider services)
    {
        Func<App> getApp = () => new App(services);

        return AppBuilder.Configure<App>(getApp)
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
    }


}
