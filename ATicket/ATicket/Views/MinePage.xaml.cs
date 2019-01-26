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
	public partial class MinePage : ContentPage
	{
        MineViewModel viewModel;
        public MinePage ()
		{
			InitializeComponent ();
            BindingContext = viewModel = new MineViewModel();
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {

        }
        private void Search_Clicked(object sender, EventArgs e)
        {

        }
    }
}