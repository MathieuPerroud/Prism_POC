using Prism.Commands;
using Prism.Navigation;

namespace Prism_POC.Core.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand NavigateToSecondPageCommand { get; private set; }
        public string Welcome { get; set; } = "Bienvenue dans le POC Page Main";
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            NavigateToSecondPageCommand = new DelegateCommand(NavigateToSecondPage);
        }
        void NavigateToSecondPage()
        {
            NavigationService.NavigateAsync("SecondPage");
        }
    }
}
