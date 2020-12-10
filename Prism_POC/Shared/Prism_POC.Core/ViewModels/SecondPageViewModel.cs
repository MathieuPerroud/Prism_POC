using Prism.Navigation;

namespace Prism_POC.Core.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        public string Welcome { get; set; } = "Bienvenue dans le POC Page Second";
        public SecondPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Second Page";
        }

        //public override void OnNavigatedFrom(INavigationParameters parameters)
        //{

        //}
    }
}
