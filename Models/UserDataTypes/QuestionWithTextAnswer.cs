using System.Runtime.ConstrainedExecution;
using Avalonia_TestManagerForBKStudia.Infrastructure.Enums;
using Avalonia_TestManagerForBKStudia.Models.Interfaces;

namespace Avalonia_TestManagerForBKStudia.Models.UserDataTypes
{
    public class QuestionWithTextAnswer : IQuestion
    {
        public required int Id { get; init; }
        public required string Text { get; set; }
        public QuestionTypeEnum QuestionType
            => QuestionTypeEnum.QuestionWithTextAnswer;
        public required IAnswer Answer { get; set; }

        public bool AnswerValidation(IAnswer correctanswer)
        {
            return correctanswer.Equals(Answer);
        }

        public void DeleteCorrectAnswer()
        {
            (Answer as TextAnswer).Text = string.Empty;
        }

        public IAnswer? GetCorrectAnswer()
        {
            return new TextAnswer
            {
                QuestionId = (Answer as TextAnswer).QuestionId,
                Text = (Answer as TextAnswer).Text,
                IsCorrect = (Answer as TextAnswer).IsCorrect,
            };
        }
    }
}
