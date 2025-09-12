using Avalonia_TestManagerForBKStudia.Infrastructure.Enums;

namespace Avalonia_TestManagerForBKStudia.Models.Interfaces
{
    public interface IQuestion
    {
        int Id { get; set; }
        string TextQuestion { get; set; }
        QuestionTypeEnum QuestionType { get; }
    }
}
