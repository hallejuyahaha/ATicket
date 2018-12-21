using ATicket.ViewModels;
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
	public partial class HomePage : ContentPage
	{
        HomeViewModel viewModel;

        public HomePage ()
		{
			InitializeComponent ();
            BindingContext = viewModel = new HomeViewModel();
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {

        }
        private void Search_Clicked(object sender, EventArgs e)
        {

        }
    }
}