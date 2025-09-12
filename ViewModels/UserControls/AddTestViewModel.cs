using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.ViewModels.Base;

namespace Avalonia_TestManagerForBKStudia.ViewModels.UserControls
{
    public class AddTestViewModel : BaseViewModel
    {
        public AddTestViewModel(INavigation navigation, IFileReader fileReader, IFileWriter fileWriter)
            : base(navigation, fileReader, fileWriter)
        {
        }
    }
}
