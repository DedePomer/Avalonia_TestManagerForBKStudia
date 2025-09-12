using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.ViewModels.Base;
using Avalonia_TestManagerForBKStudia.ViewModels.UserControls;

namespace Avalonia_TestManagerForBKStudia.ViewModels
{
    public partial class MainWindowViewModel : BaseViewModel
    {
        public BaseViewModel CurrentViewModel
            => Navigation.CurrentViewModel;

        public MainWindowViewModel(INavigation navigation, IFileReader fileReader, IFileWriter fileWriter)
            : base(navigation, fileReader, fileWriter)
        {
            Navigation.CurrentViewModelChanged += () => OnCurrentUserContorlChenged();
            Navigation.CurrentViewModel = new MainMenuViewModel(Navigation, FileReader, FileWriter);
        }

        private void OnCurrentUserContorlChenged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
