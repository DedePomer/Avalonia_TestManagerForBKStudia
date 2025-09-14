using System;
using Avalonia_TestManagerForBKStudia.Models.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia_TestManagerForBKStudia.Models.UserDataTypes
{
    public class TextAnswer : ObservableObject, IAnswer
    {
        private bool _isCorrect = true;

        public required bool IsCorrect 
        { 
            get { return _isCorrect; }
            set { SetProperty(ref _isCorrect, value); }
        
        } 
        public required string Text { get; set; }
        public required int QuestionId { get; init; }

        public override bool Equals(object? obj)
        {
            if (obj is not TextAnswer other)
                return false;
            return Text == other.Text &&
                IsCorrect == other.IsCorrect &&
                QuestionId == other.QuestionId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IsCorrect, Text, QuestionId);
        }
    }
}
