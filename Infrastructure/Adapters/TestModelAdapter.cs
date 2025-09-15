using System.Collections.ObjectModel;
using Avalonia_TestManagerForBKStudia.Models.UserDataTypes;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Adapters
{
    public static class TestModelAdapter
    {
        /// <summary>
        /// Метод создаёт список из QuestionWithCorrectAnswer на базе TestModel.Questions
        /// </summary>
        /// <param name="test"></param>
        /// <returns></returns>
        public static ObservableCollection<QuestionWithCorrectAnswer> AdaptToQuestionWithCorrectAnswer(TestModel test)
        {
            ObservableCollection<QuestionWithCorrectAnswer> questions = new();

            foreach (var question in test.Questions!)
            {
                questions.Add(new QuestionWithCorrectAnswer()
                {
                    CorrectAnswer = question.GetCorrectAnswer(),
                    Question = question,
                });
                question.DeleteCorrectAnswer();
            }
            return questions;
        }
    }
}
