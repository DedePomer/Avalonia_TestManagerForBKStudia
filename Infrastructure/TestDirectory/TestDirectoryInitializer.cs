using System.IO;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.TestDirectory
{
    /// <summary>
    /// Клас отвечает за создание директории, в которой будут хранится тесты
    /// </summary>
    public class TestDirectoryInitializer
    {
        private readonly string _directoryPath;

        public TestDirectoryInitializer(string directoryPath) 
        {
            _directoryPath = directoryPath;
        }

        public void Initialize()
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }
        }
    }
}
