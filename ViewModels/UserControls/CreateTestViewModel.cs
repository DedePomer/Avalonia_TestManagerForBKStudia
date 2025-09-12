using Avalonia_TestManagerForBKStudia.Infrastructure.Enums;
using Avalonia_TestManagerForBKStudia.Infrastructure.Helpers;
using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.Models.UserDataTypes;
using Avalonia_TestManagerForBKStudia.ViewModels.Base;
using CommunityToolkit.Mvvm.Input;

namespace Avalonia_TestManagerForBKStudia.ViewModels.UserControls
{
    public partial class CreateTestViewModel : BaseViewModel
    {
        public QuestionTypeEnum QuestionTypeIndex { get; set; } = 0;
        public int MaximumQuestion { get; } = 30;
        public int MinimumQuestion { get; } = 8;
        public int QuestionCount { get; set; } = 10;
        public TestModel Test { get; set; } = TestHelper.CreateTest();

        public CreateTestViewModel(INavigation navigation, IFileReader fileReader, IFileWriter fileWriter)
            : base(navigation, fileReader, fileWriter)
        { }



        [RelayCommand]
        private void AddQuestion(object? obj)
        {

        }
        [RelayCommand]
        private void CreateTest(object? obj)
        {

        }
        [RelayCommand]
        private void NvigateToMenuView(object? obj)
        {
            Navigation.CurrentViewModel = new MainMenuViewModel(Navigation, FileReader, FileWriter);
        }

    }
}
