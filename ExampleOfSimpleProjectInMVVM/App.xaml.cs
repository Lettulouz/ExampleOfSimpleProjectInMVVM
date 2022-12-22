using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using ExampleOfSimpleProjectInMVVM;
using ExampleOfSimpleProjectInMVVM.Models;
using ExampleOfSimpleProjectInMVVM.Services;
using ExampleOfSimpleProjectInMVVM.Stores;
using ExampleOfSimpleProjectInMVVM.ViewModels;
using Timer = System.Threading.Timer;

namespace ExampleOfSimpleProjectInMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static NavigationStore _navigationStore;

        public App()
        {
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = CreateMainViewModel();
            _navigationStore.TopBarViewModel = new TopBarViewModel(0);
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore),
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

        private static HomePageViewModel CreateMainViewModel()
        {
            return new HomePageViewModel();
        }
        
    }
    
}