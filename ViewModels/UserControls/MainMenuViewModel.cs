using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.ViewModels.Base;

namespace Avalonia_TestManagerForBKStudia.ViewModels.UserControls
{
    public class MainMenuViewModel : BaseViewModel
    {
        public MainMenuViewModel(INavigation navigation, IFileReader fileReader, IFileWriter fileWriter)
            : base(navigation, fileReader, fileWriter)
        {

        }
    }
}
