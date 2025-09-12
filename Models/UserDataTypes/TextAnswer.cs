using Avalonia_TestManagerForBKStudia.Models.Interfaces;

namespace Avalonia_TestManagerForBKStudia.Models.UserDataTypes
{
    public class TextAnswer : IAnswer
    {
        public required bool IsCorrect { get; set; } = true;
        public required string Text { get; set; }
        public required int QuestionId { get; init; }
    }
}
