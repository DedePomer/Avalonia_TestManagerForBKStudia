using System;
using Avalonia_TestManagerForBKStudia.ViewModels.Base;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces
{
    public interface INavigation
    {
        BaseViewModel CurrentViewModel { get; set; }
    }
}
