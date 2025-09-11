using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia_TestManagerForBKStudia.Infrastructure.Interfaces
{
    public interface INavigation
    {
        IPage CurrentViewModel { get; set; }
    }
}
