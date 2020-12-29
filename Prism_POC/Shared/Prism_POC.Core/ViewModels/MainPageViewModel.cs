using MvvmHelpers.Commands;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prism_POC.Core.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public AsyncCommand NavigateToSecondPageCommand { get; private set; }
        public string Welcome { get; set; } = "Bienvenue dans le POC Page Main";
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            
            NavigateToSecondPageCommand = new AsyncCommand(NavigateToSecondPage, o => CanExecuteCommand(o), exception => Console.WriteLine(exception.Message));
        }
        async Task NavigateToSecondPage()
        {
            await NavigationService.NavigateAsync("SecondPage");
        }
        bool CanExecuteCommand(object canExecute) => true;
    }
}
