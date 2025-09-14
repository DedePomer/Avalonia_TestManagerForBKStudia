using System.Collections.ObjectModel;
using Avalonia_TestManagerForBKStudia.Infrastructure.Enums;
using Avalonia_TestManagerForBKStudia.Models.Interfaces;
using Avalonia_TestManagerForBKStudia.Models.UserDataTypes;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Helpers
{
    public static class QuestionHelper
    {
        private static int _questionId = 0;
        public static IQuestion GetQuestion(QuestionTypeEnum questionType)
        {
            switch (questionType)
            {
                case QuestionTypeEnum.QuestionWithTextAnswer:
                    return new QuestionWithTextAnswer()
                    { 
                        Id = _questionId,
                        Text =string.Empty,
                        Answer = new TextAnswer()
                        { 
                            IsCorrect = true,
                            Text = string.Empty,
                            QuestionId = _questionId++,
                        }
                    };
                case QuestionTypeEnum.MultipleChoiceQuestionWithOneAnswer:
                    return new MultipleChoiceQuestionWithOneAnswer()
                    {
                        Id = _questionId++,
                        Text = string.Empty,
                        Answers = new ObservableCollection<IAnswer>()
                    };
                default:
                    throw new System.Exception($"Такого типа нет {questionType}");
            }
        }
    }
}
