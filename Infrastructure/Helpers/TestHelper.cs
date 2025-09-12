using System.Collections.ObjectModel;
using Avalonia_TestManagerForBKStudia.Models.Interfaces;
using Avalonia_TestManagerForBKStudia.Models.UserDataTypes;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Helpers
{
    public static class TestHelper
    {
        public static TestModel CreateTest()
        {
            return new TestModel()
            {
                DirectoryPath = string.Empty,
                Questions = new ObservableCollection<IQuestion>(),
            };
        }
        public static TestModel CreateTest(string name, string path)
        {
            return new TestModel()
            {
                Name = name,
                DirectoryPath = path,
            };
        }
        public static TestModel CreateTest(string name, string path, ObservableCollection<IQuestion> questions)
        {
            return new TestModel()
            {
                Name = name,
                DirectoryPath = path,
                Questions = questions,
            };
        }
    }
}
