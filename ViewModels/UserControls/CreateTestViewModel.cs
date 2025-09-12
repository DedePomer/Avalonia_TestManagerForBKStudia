using System.IO.Pipelines;
using System.Linq;
using System.Threading.Tasks;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia_TestManagerForBKStudia.Infrastructure.Enums;
using Avalonia_TestManagerForBKStudia.Infrastructure.Helpers;
using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using Avalonia_TestManagerForBKStudia.Models.Interfaces;
using Avalonia_TestManagerForBKStudia.Models.UserDataTypes;
using Avalonia_TestManagerForBKStudia.ViewModels.Base;
using CommunityToolkit.Mvvm.Input;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;

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
        private async Task AddQuestion(object? obj)
        {
            if (Test.Questions?.Count < QuestionCount)
            {
                Test.Questions
                    .Add(QuestionHelper
                    .GetQuestion(QuestionTypeIndex));
            }
            else
            {
                var desktop = Avalonia.Application.Current?.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime;
                await MessageBoxManager
                          .GetMessageBoxStandard("Уведомление", "Больше вопросов нельзя", ButtonEnum.Ok)
                          .ShowWindowDialogAsync(desktop!.MainWindow!);
            }
        }
        [RelayCommand]
        private void CreateTest(object? obj)
        {
            FileWriter.WriteAsync(Test);
        }
        [RelayCommand]
        private void NvigateToMenuView(object? obj)
        {
            Navigation.CurrentViewModel = new MainMenuViewModel(Navigation, FileReader, FileWriter);
        }


        #region Tempalte commands
        [RelayCommand]
        private void DeleteQuestion(object? obj)
        {
            var deleteQuestio = obj as IQuestion;
            Test.Questions?.Remove(deleteQuestio!);
        }
        [RelayCommand]
        private void AddAnswerOnMultipleChoiceQuestionWithOneAnswer(object? obj)
        {
            var question = obj as MultipleChoiceQuestionWithOneAnswer;
            question?.Answers.Add(new TextAnswer()
            {
                IsCorrect = false,
                Text = string.Empty,
                QuestionId = question.Id,
            });
        }
        [RelayCommand]
        private void DeleteAnswerOnMultipleChoiceQuestionWithOneAnswer(object? obj)
        {
            var answer = obj as TextAnswer;
            var question = Test
                .Questions?
                .FirstOrDefault(x => x.Id == answer?.QuestionId) as MultipleChoiceQuestionWithOneAnswer;

            question
                ?.Answers
                .Remove(answer!);
        }
        #endregion
    }
}
