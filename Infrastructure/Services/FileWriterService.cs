using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using Avalonia_TestManagerForBKStudia.Infrastructure.Helpers;
using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.Models.UserDataTypes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Avalonia_TestManagerForBKStudia.Infrastructure.Constants;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Services
{
    public class FileWriterService : IFileWriter
    {
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true,
        };
        private readonly IServiceProvider _services;
        public FileWriterService(IServiceProvider services)
        {
            _services = services;
        }

        public async Task WriteAsync(TestModel test, string? path)
        {
            string directoryPath;
            if (path == default)
            {
                directoryPath = _services
                    .GetRequiredService<IConfiguration>()[DirectoryConstants.TEST_DIRECTORY_KEY]!;
            }
            else 
            {
                directoryPath = path;
            }

            string fullPath = FileHelper
                    .GetVerifyFilePath(directoryPath, test.Name);


            using (var stream = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
            {
                await JsonSerializer.SerializeAsync(stream, test, _options);
            }
        }
    }
}
