using ATicket.Models;
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
    public partial class MonitorItemPage : ContentPage
    {
        private ServiceReference1.Service1 service1;
        public MonitorItemPage()
        {
            InitializeComponent();
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            if (actorName.Text == null || actorName.Text.Trim() == "")
            {
                await DisplayAlert("提示", "歌手不能为空", "OK");
            }
            else
            {
                ServiceReference1.monitor item = new ServiceReference1.monitor()
                {
                    id = 1,
                    actor = actorName.Text.Trim(),
                    username = "admin"
                };
                try
                {
                    bool Result;
                    bool ResultS;
                    service1 = new ServiceReference1.Service1();
                    service1.AddMonitors(item, out Result, out ResultS);
                    if (Result)
                    {
                        await Navigation.PopModalAsync(); //推出 退出本页
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
    }
}