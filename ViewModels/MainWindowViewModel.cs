using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Avalonia_TestManagerForBKStudia.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private int _index = 0;

        [ObservableProperty]
        private string _greeting = "Welcome to Avalonia!";


        public MainWindowViewModel()
        {
        }

        [RelayCommand]
        private void ChangeText(object? obj)
        {
            var a = obj;
            Greeting = Convert.ToString(_index);
            _index++;
        }
    }
}
