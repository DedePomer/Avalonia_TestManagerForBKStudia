using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia_TestManagerForBKStudia.ViewModels.UserControls
{
    public class MainMenuUserControl : ObservableObject, IPage
    {
        private readonly INavigation _navigation;

        public MainMenuUserControl(INavigation navigation)
        {
            _navigation = navigation;
        }
    }
}
