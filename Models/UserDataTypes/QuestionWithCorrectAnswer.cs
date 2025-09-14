using Avalonia_TestManagerForBKStudia.Models.Interfaces;

namespace Avalonia_TestManagerForBKStudia.Models.UserDataTypes
{
    public class QuestionWithCorrectAnswer 
    {
        public required IAnswer? CorrectAnswer { get; init; }
        public required IQuestion Question { get; init; }

    }
}
