using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ONEULApp.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ONEULApp.ViewModels;

namespace ONEULApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();

            mainViewModel.Navigation = Navigation;
            BindingContext = mainViewModel;
        }

        public async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new WritePage(new WriteViewModel())));
        }
    }
}