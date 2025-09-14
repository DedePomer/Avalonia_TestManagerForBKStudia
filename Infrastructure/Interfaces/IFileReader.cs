using Avalonia_TestManagerForBKStudia.Models.UserDataTypes;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces
{
    public interface IFileReader
    {
        TestModel ReadTestAsync(string path);
    }
}
