using Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia_TestManagerForBKStudia.ViewModels.Base
{
    public abstract class BaseViewModel: ObservableObject
    {
        protected INavigation Navigation { get; }
        protected IFileReader FileReader { get; }
        protected IFileWriter FileWriter { get; }

        protected BaseViewModel(INavigation navigation, IFileReader fileReader, IFileWriter fileWriter)
        {
            Navigation = navigation;
            FileReader = fileReader;
            FileWriter = fileWriter;
        }
    }
}
