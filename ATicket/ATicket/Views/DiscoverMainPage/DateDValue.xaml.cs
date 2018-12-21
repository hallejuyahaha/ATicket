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
    public partial class DateDValue : ContentPage
    {
        DateDValueModel viewModel;
        public DateDValue()
        {
            InitializeComponent();
            BindingContext = viewModel = new DateDValueModel();
        }

        void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            string r = "";
            TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date;
            r += "相隔 " + timeSpan.Days + " 天  \r\n";

            DateTime temp = startDatePicker.Date;
            TimeSpan weekend = new TimeSpan();
            while (temp < endDatePicker.Date)
            {
                if (temp.DayOfWeek.ToString() == "Saturday" || temp.DayOfWeek.ToString() == "Sunday")
                {
                    weekend += new TimeSpan(24, 0, 0); ;
                }
                temp = temp.AddDays(1);
            }
            r += "其中有 " + weekend.Days + " 天是周末";

            Result.Text = String.Format(r);
        }
    }
}