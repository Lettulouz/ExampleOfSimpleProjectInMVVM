using System;
using ExampleOfSimpleProjectInMVVM.Stores;
using ExampleOfSimpleProjectInMVVM.ViewModels;

namespace ExampleOfSimpleProjectInMVVM.Services;

public class NavigationService
{
    private readonly NavigationStore _navigationStore;

    public NavigationService(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
    }
    public void Navigate(ViewModelBase viewModelBase)
    {
        _navigationStore.CurrentViewModel = viewModelBase;
    }
}
