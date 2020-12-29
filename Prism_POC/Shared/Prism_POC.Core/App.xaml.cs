using Prism;
using Prism.Ioc;
using Prism_POC.Core.ViewModels;
using Prism_POC.Core.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;
using Prism_POC.Core.Repositories.Starships;
using Prism_POC.Core.UseCases.Starships;

namespace Prism_POC
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterSingleton<IStarshipRepository, StarshipRepository>();


            //containerRegistry.RegisterSingleton<IGetAllStarships, GetAllStarships>();


            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<SecondPage, SecondPageViewModel>();
        }
    }
}
