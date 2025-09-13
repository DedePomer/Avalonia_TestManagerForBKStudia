using System.Text.Json.Serialization;
using Avalonia_TestManagerForBKStudia.Models.UserDataTypes;

namespace Avalonia_TestManagerForBKStudia.Models.Interfaces
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
    [JsonDerivedType(typeof(TextAnswer), nameof(TextAnswer))]
    public interface IAnswer
    {
        bool IsCorrect { get; set; }
    }
}
