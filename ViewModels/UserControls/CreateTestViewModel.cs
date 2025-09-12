using System.Collections.ObjectModel;
using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.Models.Interfaces;
using Avalonia_TestManagerForBKStudia.ViewModels.Base;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Avalonia_TestManagerForBKStudia.ViewModels.UserControls
{
    public partial class CreateTestViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _testName = string.Empty;

        public int QuestionTypeIndex { get; set; } = 0;
        public int MaximumQuestion { get; } = 30;
        public int MinimumQuestion { get; } = 8;
        public int QuestionCount { get; set; } = 10;
        public ObservableCollection<IQuestion> Questions { get; set; }

        public CreateTestViewModel(INavigation navigation, IFileReader fileReader, IFileWriter fileWriter)
            : base(navigation, fileReader, fileWriter)
        {}



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
