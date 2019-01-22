using ATicket.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ATicket.Views.DiscoverMainPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MonitorPage : ContentPage
	{
        MonitorViewModel viewModel;
        private ServiceReference1.Service1 service1;
        public MonitorPage ()
		{
			InitializeComponent ();
            BindingContext = viewModel = new MonitorViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.LoadItemsCommand.Execute(null);
        }

        private async void Add_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new MonitorItemPage()));
        }
        private async void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var item = mi.CommandParameter as ServiceReference1.monitor;

            if (item == null)
            { return; }
            else
            {
                var answer = await DisplayAlert("删除?", "确定不监控这个歌手了吗？", "Yes", "No");
                if (answer)
                {
                    try
                    {
                        bool Result;
                        bool ResultS;
                        service1 = new ServiceReference1.Service1();
                        service1.DeleteMonitors(item, out Result, out ResultS);
                        if (Result)
                        {
                            //成功
                        }
                        else
                        {
                            await DisplayAlert("提示", "添加错误", "OK");
                        }
                    }
                    catch (Exception eea)
                    {
                        Debug.WriteLine(eea.Message);
                        await DisplayAlert("错误", "与服务器链接错误", "OK");
                    }
                }
            }

            ItemsListView.SelectedItem = null;
            this.OnAppearing();
        }        
    }
}