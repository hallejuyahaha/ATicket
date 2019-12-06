using ATicket.Models;
using ATicket.Module;
using ATicket.RestApiClent;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ATicket.Views.DiscoverMainPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MonitorItemPage : ContentPage
    {
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
                Monitor item = new Monitor()
                {
                    Actor = actorName.Text.Trim(),
                    Username = "admin"
                };
                try
                {
                    bool Result = RestHelper.AddMonitor(item);
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