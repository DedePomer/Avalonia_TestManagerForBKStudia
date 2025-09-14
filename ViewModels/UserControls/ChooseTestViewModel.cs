using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia_TestManagerForBKStudia.Infrastructure.Helpers;
using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.Models.UserDataTypes;
using Avalonia_TestManagerForBKStudia.ViewModels.Base;
using CommunityToolkit.Mvvm.Input;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;

namespace Avalonia_TestManagerForBKStudia.ViewModels.UserControls
{
    public partial class ChooseTestViewModel : BaseViewModel
    {
        public ObservableCollection<TestModel> Tests { get; set; } = TestHelper.CreateTestCollection(default);
        public ChooseTestViewModel(INavigation navigation, IFileReader fileReader, IFileWriter fileWriter)
            : base(navigation, fileReader, fileWriter)
        {

        }

        [RelayCommand]
        private async Task ScrollViewerLoaded(object? obj)
        {
            if (Tests.Count.Equals(0))
            {
                Navigation.CurrentViewModel = new MainMenuViewModel(Navigation, FileReader, FileWriter);
                var desctop = Avalonia.Application.Current?.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime;
                await MessageBoxManager
                          .GetMessageBoxStandard("Уведомление", "Ни созданно не одного файла теста", ButtonEnum.Ok)
                          .ShowWindowDialogAsync(desctop!.MainWindow!);
            }
        }
        [RelayCommand]
        private void ChooseTest(object? obj)
        {
            var test = obj as TestModel;
        }
    }
}
