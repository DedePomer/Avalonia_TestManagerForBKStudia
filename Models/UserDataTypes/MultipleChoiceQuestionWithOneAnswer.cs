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

        public bool AnswerValidation(IAnswer correctanswer)
        {
            foreach (var answer in Answers)
            {
                if (answer.IsCorrect == true)
                {
                    return correctanswer.Equals(answer);
                }
            }
            return false;
        }

        public void DeleteCorrectAnswer()
        {
            foreach (var answer in Answers)
            {
                if (answer.IsCorrect == true)
                {
                    answer.IsCorrect = false;
                }
            }
        }

        public IAnswer? GetCorrectAnswer()
        {
            foreach (TextAnswer answer in Answers) 
            {
                if (answer.IsCorrect == true)
                {
                    return new TextAnswer
                    { 
                        QuestionId = answer.QuestionId,
                        Text = answer.Text,
                        IsCorrect = answer.IsCorrect,
                    };
                }
            }
            return default;
        }
    }
}
