using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.ViewModels.Base;
using CommunityToolkit.Mvvm.Input;

namespace Avalonia_TestManagerForBKStudia.ViewModels.UserControls
{
    public partial class MainMenuViewModel : BaseViewModel
    {
        public MainMenuViewModel(INavigation navigation, IFileReader fileReader, IFileWriter fileWriter)
            : base(navigation, fileReader, fileWriter)
        { }




        [RelayCommand]
        private void NavigateToCreateTest(object? obj)
        {
            Navigation.CurrentViewModel = new CreateTestViewModel(Navigation, FileReader, FileWriter);
        }

        [RelayCommand]
        private void NavigateToChooseTest(object? obj)
        {
            Navigation.CurrentViewModel = new ChooseTestViewModel(Navigation, FileReader, FileWriter);
        }

        [RelayCommand]
        private void Exit(object? obj)
        {
            if (Application.Current != null 
                && Application.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime lifetime)
            {
                lifetime.MainWindow?.Close();
            }
        }
    }
}
