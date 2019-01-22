using ATicket.DB;
using ATicket.Models;
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
    public partial class NewNotePadItem : ContentPage
    {
        private NotePadDataAccess dataAccess;
        public NotePadItems Item { get; set; }
        public NewNotePadItem()
        {
            //添加
            InitializeComponent();
            NotePadItems NewItem = new NotePadItems() { Content=null, NTitle=null, Time = DateTime.Now };
            Item = NewItem;
            BindingContext = Item;
        }
        public NewNotePadItem(NotePadItems NewItem)
        {
            //更新
            InitializeComponent();
            Item = NewItem;
            //{
            //    Content = "This is Conete",
            //    NTitle = "title",
            //    Time = DateTime.Now
            //};
            BindingContext = Item;
        }
        async void Save_Clicked(object sender, EventArgs e)
        {
            if (title.Text == null || title.Text.Trim() == "")
            {
                await DisplayAlert("提示", "标题 不能为空", "OK");
            }
            else if (Item == null)
            {
                NotePadItems item = new NotePadItems()
                {
                    Content = content.Text,
                    NTitle = title.Text,
                    Time = DatePicker.Date
                };
                dataAccess = new NotePadDataAccess();
                dataAccess.SaveNotePadItems(item);
                await Navigation.PopModalAsync(); //推出 退出本页
            }
            else if (Item != null)
            {
                Item.NTitle = title.Text;
                Item.Content = content.Text;
                Item.Time = DatePicker.Date;
                dataAccess = new NotePadDataAccess();
                dataAccess.SaveNotePadItems(Item);
                await Navigation.PopModalAsync(); //推出 退出本页
            }
        }
    }
}