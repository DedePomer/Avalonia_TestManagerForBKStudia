using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Services
{
    public class NavigationService<T> : ObservableObject, INavigation 
        where T : IPage, new()
    {
        private IPage _currentViewModel;
        public NavigationService()
        {
            _currentViewModel = new T();
        }
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
