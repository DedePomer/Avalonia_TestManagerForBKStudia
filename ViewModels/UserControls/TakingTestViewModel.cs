using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Avalonia_TestManagerForBKStudia.Infrastructure.Adapters;
using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.Models.UserDataTypes;
using Avalonia_TestManagerForBKStudia.ViewModels.Base;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Avalonia_TestManagerForBKStudia.ViewModels.UserControls
{
    public partial class TakingTestViewModel : BaseViewModel
    {
        private readonly string _testPath;

        [ObservableProperty]
        private bool _isCorrectAnswerVisibility = false;
        [ObservableProperty]
        private string _countCorrectQuestion;


        public ObservableCollection<QuestionWithCorrectAnswer> QuestionsWithCorrectAnswer { get; set; }
            = new ObservableCollection<QuestionWithCorrectAnswer>();
        public TakingTestViewModel(INavigation navigation, IFileReader fileReader, IFileWriter fileWriter, string testPath)
            : base(navigation, fileReader, fileWriter)
        {
            _testPath = testPath;

        }


        [RelayCommand]
        private async Task GridLoadedCommand(object? obj)
        {
            TestModel test = await FileReader.ReadTestAsync(_testPath);

            QuestionsWithCorrectAnswer = TestModelAdapter.AdaptToQuestionWithCorrectAnswer(test);
        }
        [RelayCommand]
        private void EndTest(object? obj)
        {

        }
        [RelayCommand]
        private void NvigateToMenuView(object? obj)
        {
            Navigation.CurrentViewModel = new MainMenuViewModel(Navigation, FileReader, FileWriter);
        }

    }
}
