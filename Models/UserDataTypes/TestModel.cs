using System.Collections.ObjectModel;
using Avalonia_TestManagerForBKStudia.Models.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia_TestManagerForBKStudia.Models.UserDataTypes
{
    public partial class TestModel : ObservableObject
    {
        [ObservableProperty]
        private string _name = string.Empty;
        public required string DirectoryPath { get; set; }
        public ObservableCollection<IQuestion>? Questions { get; set; }
    }
}
