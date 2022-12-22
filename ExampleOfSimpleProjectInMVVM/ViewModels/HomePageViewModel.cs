using System;
using System.Windows.Input;
using ExampleOfSimpleProjectInMVVM.Commands;

namespace ExampleOfSimpleProjectInMVVM.ViewModels;

public class HomePageViewModel : ViewModelBase
{
    public int LabelInputValue = 0;
    public string LabelInput
    {
        get => LabelInputValue.ToString();
        set
        {
            LabelInputValue = Int32.Parse(value);
            OnPropertyChanged("LabelInput");
        }
    }
    
    public ICommand AddOneCommand { get; }

    public HomePageViewModel()
    {
        AddOneCommand = new AddOneCommand(this);
    }
}