using Avalonia_TestManagerForBKStudia.Models.UserDataTypes;
using System.Collections.ObjectModel;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Helpers
{
    public static class ValidationTestHelper
    {
        public static int GetCountCorrectlyAnsweredQuestion(ObservableCollection<QuestionWithCorrectAnswer> questions)
        {
            int countCorrectQuestion = 0;
            foreach (var question in questions)
            {
                if (question.CorrectAnswer != null && question.Question.AnswerValidation(question.CorrectAnswer)) 
                    countCorrectQuestion++;
                else if (question.CorrectAnswer == null && question.Question.GetCorrectAnswer() == null)
                    countCorrectQuestion++;
            }
            return countCorrectQuestion;
        }
    }
}
