using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ONEULApp.ViewModels;

namespace ONEULApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WritePage : ContentPage
    {
        public WritePage(WriteViewModel writeViewModel)
        {
            InitializeComponent();

            writeViewModel.Navigation = Navigation;
            BindingContext = writeViewModel;
        }

        private void commandWrite_Clicked(object sender, EventArgs e)
        {
            OneulDB oneuldb = new OneulDB()
            {
                Title = writeTitle.Text,
                Memo = writeMemo.Text,
                Time = DateTime.Now
            };
        }
    }
}