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
    }
}
