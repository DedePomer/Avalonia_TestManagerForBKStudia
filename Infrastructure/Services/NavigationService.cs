using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.ViewModels.Base;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Services
{
    public class NavigationService : ObservableObject, INavigation 
    {
        private BaseViewModel? _currentViewModel;
        public required BaseViewModel CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;

                OnPropertyChanged(nameof(_currentViewModel));
            }
        }
    }
}
