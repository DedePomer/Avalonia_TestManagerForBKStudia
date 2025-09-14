using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Markup.Xaml.Templates;
using Avalonia_TestManagerForBKStudia.Models.UserDataTypes;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Selectors
{
    public class TakingTestTemplateSelector
    {


        public DataTemplate QuestionWithTextAnswerTemplate { get; set; }
        public DataTemplate MultipleChoiceQuestionWithOneAnswerTemplate { get; set; }

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
