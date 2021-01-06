using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ONEULApp.Data;

namespace ONEULApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(Locator.Resolve<Tabbed>());

            Locator.Initialize();

            OneulRepository repository = Locator.Resolve<OneulRepository>();
            repository.Initialize();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
