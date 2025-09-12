using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Services
{
    public class NavigationService : ObservableObject, INavigation 
    {
        private IPage? _currentViewModel;
        public required IPage CurrentViewModel
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
