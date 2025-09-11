using System;
using Avalonia_TestManagerForBKStudia.Infrastructure.TestDirectory;
using Avalonia_TestManagerForBKStudia.ViewModels;
using Avalonia_TestManagerForBKStudia.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddSingleton<MainWindowViewModel>();
        }

        public static void AddDirectory(this IServiceCollection services , IConfiguration configuration)
        {
            var directoryPath = configuration["TestDirectoryPath"];
            ArgumentNullException.ThrowIfNullOrEmpty(directoryPath, nameof(directoryPath));
            services.AddSingleton<TestDirectoryInitializer>(new TestDirectoryInitializer(directoryPath));
        }
    }
}
