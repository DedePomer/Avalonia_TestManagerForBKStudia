using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Markup.Xaml.Templates;
using Avalonia_TestManagerForBKStudia.Models.UserDataTypes;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Selectors
{
    public class CreateTestTemplateSelctor : IDataTemplate
    {
        public required DataTemplate QuestionWithTextAnswerTemplate { get; set; }
        public required DataTemplate MultipleChoiceQuestionWithOneAnswerTemplate { get; set; }

        public Control? Build(object? param)
        {
            if (param is QuestionWithTextAnswer)
            {
                return QuestionWithTextAnswerTemplate.Build(param);
            }
            else if (param is MultipleChoiceQuestionWithOneAnswer)
            {
                return MultipleChoiceQuestionWithOneAnswerTemplate.Build(param);
            }

            return null;
        }

        public bool Match(object? data)
        {
            return data is QuestionWithTextAnswer || data is MultipleChoiceQuestionWithOneAnswer;
        }
    }
}
