using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia_TestManagerForBKStudia.ViewModels.UserControls
{
    public class MainMenuViewModel : ObservableObject, IPage
    {
        private readonly INavigation _navigation;
        private readonly IFileReader _fileReader;
        private readonly IFileWriter _fileWriter;

        public MainMenuViewModel(INavigation navigation, IFileReader fileReader, IFileWriter fileWriter)
        {
            _navigation = navigation;
            _fileReader = fileReader;
            _fileWriter = fileWriter;
        }
    }
}
