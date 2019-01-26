using ATicket.Models;
using ATicket.Services;
using System.Linq;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ATicket.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private ServiceReference1.Service1 service1;
        public ObservableCollection<show> Items { get; set; }
        public Command LoadItemsCommand { get; set; }
        public HomeViewModel()
        {
            Title = "ATicket";
            Items = new ObservableCollection<show>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());//load item方法

            try
            {
                service1 = new ServiceReference1.Service1();
                var keys = service1.GetShow("admin");
                Dictionary<string, showstarts[]> show = new Dictionary<string, showstarts[]>(); //从wcf获取showlist
                foreach (var item in keys)
                {
                    show.Add(item.Key, item.Value);
                }
                List<showstarts> newshow = new List<showstarts>(show["newshow"]);
                List<showstarts> oldshow = new List<showstarts>(show["oldshow"]);
                newshow = newshow.OrderBy(_x => _x.startime).ToList();
                oldshow = oldshow.OrderBy(_x => _x.startime).ToList();

                //类型转换
                //List<show> newShow = new List<show>();
                foreach (showstarts s in newshow)
                {
                    show t = new show()
                    {
                        showname = s.showname,
                        place = s.place,
                        actor = s.actor,
                        front_image_path = s.front_image_path,
                        price = s.price,
                        readtime = s.readtime,
                        startime = s.startime,
                        type = s.type,
                        url = s.url,
                        IsNew = "New"
                    };
                    Items.Add(t);
                }
                //List<show> oldShow = new List<show>();
                foreach (showstarts s in oldshow)
                {
                    show t = new show()
                    {
                        showname = s.showname,
                        place = s.place,
                        actor = s.actor,
                        front_image_path = s.front_image_path,
                        price = s.price,
                        readtime = s.readtime,
                        startime = s.startime,
                        type = s.type,
                        url = s.url,
                        IsNew = ""
                    };
                    Items.Add(t);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
        private async Task ExecuteLoadItemsCommand()
        {

            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var keys = service1.GetShow("admin");
                Dictionary<string, showstarts[]> show = new Dictionary<string, showstarts[]>(); //从wcf获取showlist
                foreach (var item in keys)
                {
                    show.Add(item.Key, item.Value);
                }
                List<showstarts> newshow = new List<showstarts>(show["newshow"]);
                List<showstarts> oldshow = new List<showstarts>(show["oldshow"]);
                newshow = newshow.OrderBy(_x => _x.startime).ToList();
                oldshow = oldshow.OrderBy(_x => _x.startime).ToList();

                //类型转换
                //List<show> newShow = new List<show>();
                foreach (showstarts s in newshow)
                {
                    show t = new show()
                    {
                        showname = s.showname,
                        place = s.place,
                        actor = s.actor,
                        front_image_path = s.front_image_path,
                        price = s.price,
                        readtime = s.readtime,
                        startime = s.startime,
                        type = s.type,
                        url = s.url,
                        IsNew = "New"
                    };
                    Items.Add(t);
                }
                //List<show> oldShow = new List<show>();
                foreach (showstarts s in oldshow)
                {
                    show t = new show()
                    {
                        showname = s.showname,
                        place = s.place,
                        actor = s.actor,
                        front_image_path = s.front_image_path,
                        price = s.price,
                        readtime = s.readtime,
                        startime = s.startime,
                        type = s.type,
                        url = s.url,
                        IsNew = ""
                    };
                    Items.Add(t);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        public class show: ServiceReference1.showstarts
        {
            public string IsNew { set; get; }
            //public string actor;
            //public string front_image_path;
            //public string place;
            //public System.Nullable<decimal> price;
            //public System.Nullable<System.DateTime> readtime;
            //public string showname;
            //public System.Nullable<System.DateTime> startime;
            //public string type;
            //public string url;
        }
    }
}
