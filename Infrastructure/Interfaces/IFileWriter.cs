using System.Threading.Tasks;
using Avalonia_TestManagerForBKStudia.Models.UserDataTypes;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces
{
    public interface IFileWriter
    {
        Task WriteAsync(TestModel test);
    }
}
