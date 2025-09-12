using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Avalonia_TestManagerForBKStudia.Infrastructure.Helpers;
using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.Models.UserDataTypes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Services.WriterService
{
    public class FileWriterService : IFileWriter
    {
        private readonly IServiceProvider _services;
        public FileWriterService(IServiceProvider services) 
        {
            _services = services;
        }

        public async Task WriteAsync(TestModel test)
        {
            string directoryPath = _services
                .GetRequiredService<IConfiguration>()["TestDirectoryPath"]!;
            string fullPath = FileHelper
                .GetVerifyFilePath(directoryPath, test.Name);

            Stream stream = File
                .Create(fullPath);
            await JsonSerializer
                .SerializeAsync(stream, test,new JsonSerializerOptions { WriteIndented = true});
        }
    }
}
