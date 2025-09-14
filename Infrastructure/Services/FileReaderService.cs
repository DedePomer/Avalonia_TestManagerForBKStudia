using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.Models.UserDataTypes;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Services
{
    public class FileReaderService : IFileReader
    {
        private readonly IServiceProvider _services;
        public FileReaderService(IServiceProvider services)
        {
            _services = services;
        }

        public async Task<TestModel> ReadTestAsync(string path)
        {
            TestModel test;
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                test = await JsonSerializer.DeserializeAsync<TestModel>(stream) ??
                    throw new Exception("Тест не смог открыться"); ;
            }
            return test;
        }
    }
}
