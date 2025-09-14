using System;
using Avalonia_TestManagerForBKStudia.Infrastructure.Constants;
using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.Infrastructure.Services;
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

            services.AddSingleton<INavigation, NavigationService>();
            services.AddSingleton<IFileReader, FileReaderService>();
            services.AddSingleton<IFileWriter, FileWriterService>();
        }

        public static void AddDirectory(this IServiceCollection services, IConfiguration configuration)
        {
            var directoryPath = configuration[DirectoryConstants.TEST_DIRECTORY_KEY];
            ArgumentNullException.ThrowIfNullOrEmpty(directoryPath, nameof(directoryPath));
            services.AddSingleton<TestDirectoryInitializer>(new TestDirectoryInitializer(directoryPath));
        }
    }
}
