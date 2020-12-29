using Prism.Navigation;
using Prism_POC.Core.UseCases.Starships;
using System.Collections;

namespace Prism_POC.Core.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        public string Welcome { get; set; } = "Bienvenue dans le POC Page Second";
        private readonly IGetAllStarships getAllStarships;

        public IEnumerable Starships { get; set; }
        public SecondPageViewModel(INavigationService navigationService, IGetAllStarships getAllStarships)
            : base(navigationService)
        {
            this.getAllStarships = getAllStarships;
            Title = "All Starships Page";
            Starships = this.getAllStarships.Execute();
        }


    }
}
