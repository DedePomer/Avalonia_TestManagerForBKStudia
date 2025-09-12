using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.ViewModels.Base;
using Avalonia_TestManagerForBKStudia.ViewModels.UserControls;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia_TestManagerForBKStudia.ViewModels
{
    public partial class MainWindowViewModel : BaseViewModel
    {
        public ObservableObject CurrentViewModel
            => new MainMenuViewModel(Navigation, FileReader, FileWriter);

        public MainWindowViewModel(INavigation navigation, IFileReader fileReader, IFileWriter fileWriter) 
            : base(navigation, fileReader, fileWriter)
        {
        
        }      
    }
}
