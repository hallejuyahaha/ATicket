using ATicket.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ATicket.Views.DiscoverMainPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalculatorPage : ContentPage
	{
        CalculatorModel viewModel;
        public CalculatorPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new CalculatorModel();
            //await DispalyAlert(

        }
    }
}