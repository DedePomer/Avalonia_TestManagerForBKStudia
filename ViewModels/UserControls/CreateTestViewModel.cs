using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.ViewModels.Base;
using CommunityToolkit.Mvvm.Input;

namespace Avalonia_TestManagerForBKStudia.ViewModels.UserControls
{
    public partial class CreateTestViewModel : BaseViewModel
    {
        public CreateTestViewModel(INavigation navigation, IFileReader fileReader, IFileWriter fileWriter)
            : base(navigation, fileReader, fileWriter)
        {}

        [RelayCommand]
        private void NavigateToMainMenu(object? obj)
        {
            Navigation.CurrentViewModel = new MainMenuViewModel(Navigation, FileReader, FileWriter);
        }
    }
}
