using System.IO;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.TestDirectory
{
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
