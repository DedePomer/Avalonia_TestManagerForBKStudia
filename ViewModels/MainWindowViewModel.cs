using System;
using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.ViewModels.UserControls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Avalonia_TestManagerForBKStudia.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        private readonly INavigation _navigation;

        public ObservableObject CurrentViewModel => new MainMenuUserControl(_navigation);


        public MainWindowViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

    }
}
