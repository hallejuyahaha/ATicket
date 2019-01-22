using ATicket.ViewModels;
using ATicket.Views.DiscoverMainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ATicket.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DiscoverPage : ContentPage
	{
        DiscoverViewModel viewModel;
        public DiscoverPage ()
		{
			InitializeComponent ();

            BindingContext = viewModel = new DiscoverViewModel();
        }
        private async void ShowNotepadPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NotePadPage()));
        }
        private async void ShowCalculatorPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new CalculatorPage()));
        }
        private async void DateDValue(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new DateDValue()));
        }

        private async void Monitor(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new MonitorPage()));
        }
    }
}