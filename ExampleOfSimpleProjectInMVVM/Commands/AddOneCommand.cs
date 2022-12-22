using System;
using ExampleOfSimpleProjectInMVVM.ViewModels;
using Microsoft.VisualBasic.CompilerServices;

namespace ExampleOfSimpleProjectInMVVM.Commands;

public class AddOneCommand : CommandBase
{
    private HomePageViewModel _homePageViewModel;
    public AddOneCommand(HomePageViewModel homePageViewModel)
    {
        _homePageViewModel = homePageViewModel;
    }

    public override void Execute(object? parameter)
    {
        int val = Int32.Parse(_homePageViewModel.LabelInput);
        val += 1;
        _homePageViewModel.LabelInput = val.ToString();
    }
}