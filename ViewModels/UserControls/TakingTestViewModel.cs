using System.Threading.Tasks;
using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.ViewModels.Base;
using CommunityToolkit.Mvvm.Input;

namespace Avalonia_TestManagerForBKStudia.ViewModels.UserControls
{
    public partial class TakingTestViewModel : BaseViewModel
    {
        private readonly string _testPath;
        public TakingTestViewModel(INavigation navigation, IFileReader fileReader, IFileWriter fileWriter, string testPath)
            : base(navigation, fileReader, fileWriter)
        {
            _testPath = testPath;
        }


        [RelayCommand]
        private async Task GridLoadedCommand(object? obj)
        {

        }
        [RelayCommand]
        private void EndTest(object? obj)
        {

        }
        [RelayCommand]
        private void NvigateToMenuView(object? obj)
        {

        }

    }
}
