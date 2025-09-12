using System.Collections.ObjectModel;
using Avalonia_TestManagerForBKStudia.Infrastructure.Enums;
using Avalonia_TestManagerForBKStudia.Models.Interfaces;

namespace Avalonia_TestManagerForBKStudia.Models.UserDataTypes
{
    public class MultipleChoiceQuestionWithOneAnswer : IQuestion
    {
        public required int Id { get; init; }
        public required string Text { get; set; }
        public QuestionTypeEnum QuestionType
            => QuestionTypeEnum.MultipleChoiceQuestionWithOneAnswer;
        public required ObservableCollection<IAnswer> Answers { get; set; }
    }
}
