using ATicket.DB;
using ATicket.Models;
using ATicket.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private NotePadDataAccess dataAccess;
        public ObservableCollection<NotePadItems> ListItems;
        public DateDValue()
        {
            InitializeComponent();
            //BindingContext = viewModel = new DateDValueModel();
            ListItems = new ObservableCollection<NotePadItems>();
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

            //填充listview
            //viewModel.LoadItemsCommand.Execute(startDatePicker.Date, endDatePicker.Date);
            this.dataAccess = new NotePadDataAccess();
            var items = dataAccess.GetdNotePadItemsByTime(startDatePicker.Date, endDatePicker.Date);
            ListItems.Clear();
            foreach (var item in items)
            {
                ListItems.Add(item);
            }
            ItemsListView.ItemsSource = ListItems;

        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as NotePadItems;
            if (item == null)
                return;

            await Navigation.PushModalAsync(new NavigationPage(new NewNotePadItem(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }
        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    DateTimeStartEnd obj = new DateTimeStartEnd();
        //    obj.Start = startDatePicker.Date;
        //    obj.End = endDatePicker.Date;
        //    viewModel.LoadItemsCommand.Execute(obj);
        //}
    }
}