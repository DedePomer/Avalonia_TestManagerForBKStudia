using System.Text.Json.Serialization;
using Avalonia_TestManagerForBKStudia.Infrastructure.Enums;
using Avalonia_TestManagerForBKStudia.Models.UserDataTypes;

namespace Avalonia_TestManagerForBKStudia.Models.Interfaces
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
    [JsonDerivedType(typeof(MultipleChoiceQuestionWithOneAnswer), "multiToOne")]
    [JsonDerivedType(typeof(QuestionWithTextAnswer), "text")]
    public interface IQuestion
    {
        int Id { get; init; }
        string Text { get; set; }
        QuestionTypeEnum QuestionType { get; }
    }
}
