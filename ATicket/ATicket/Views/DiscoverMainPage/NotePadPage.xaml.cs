using ATicket.DB;
using ATicket.Models;
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
    public partial class NotePadPage : ContentPage
    {
        NotePadViewModel viewModel;
        private NotePadDataAccess dataAccess;
        //private NotePadDataAccess dataAccess;
        public NotePadPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new NotePadViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            //if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
            
        }
        async void Add_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewNotePadItem()));
        }

        private void Search_Clicked(object sender, EventArgs e)
        {

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
        async void OnDelete(object sender, EventArgs args)
        {
            var mi = ((MenuItem)sender);
            var item = mi.CommandParameter as NotePadItems;
            //DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
            if (item == null)
            { return; }
            else
            {
                var answer = await DisplayAlert("删除?", "确定要删除这条信息吗？", "Yes", "No");
                if (answer)
                {
                    dataAccess = new NotePadDataAccess();
                    dataAccess.DeleteNotePadItems(item);
                }
            }
            // Manually deselect item.
            ItemsListView.SelectedItem = null;
            this.OnAppearing();
        }
    }
}