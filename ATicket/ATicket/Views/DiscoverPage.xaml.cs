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
        async void ShowNotepadPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NotePadPage()));
        }
        async void ShowCalculatorPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new CalculatorPage()));
        }
        async void DateDValue(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new DateDValue()));
        }
        
    }
}