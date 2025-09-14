namespace Avalonia_TestManagerForBKStudia.Infrastructure.Constants
{
    public static class DirectoryConstants
    {
        private const string DEFAULT_VALUE = "DefaultValue";
        private static string _testsDirectoryPath = DEFAULT_VALUE;


        public const string TEST_DIRECTORY_KEY = "TestDirectoryPath";
        public static string TestsDirectoryPath
        {
            get 
            {
                return _testsDirectoryPath;
            }
            set
            {
                if (_testsDirectoryPath == DEFAULT_VALUE)
                {
                    _testsDirectoryPath = value;
                }
            }
        }
    }
}
