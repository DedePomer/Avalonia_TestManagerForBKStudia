using Avalonia_TestManagerForBKStudia.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void BuildProvider(this IServiceCollection collection)
        {
            collection.AddSingleton<MainWindow>();
        }
    }
}
