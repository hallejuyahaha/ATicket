using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ATicket.ViewModels
{
    public class MineViewModel : BaseViewModel
    {
        private ServiceReference1.Service1 service1;
        public ObservableCollection<showstarts> Items { get; set; }
        public Command LoadItemsCommand { get; set; }
        public MineViewModel()
        {
            Title = "我的";
            Items = new ObservableCollection<showstarts>();
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
                //List<showstarts> newshow = new List<showstarts>(show["newshow"]);
                //List<showstarts> oldshow = new List<showstarts>(show["oldshow"]);
                List<showstarts> allShow = new List<showstarts>(show["newshow"]).Union(new List<showstarts>(show["oldshow"])).ToList();
                List<monitor> monitors = new List<monitor>(service1.GetMonitors("admin"));

                var q = from mo in monitors
                        join sh in allShow on 
                        mo.actor equals sh.actor
                        //into temp
                        //from tt in temp.DefaultIfEmpty()
                        select new showstarts
                        {
                            actor = sh.actor,
                            front_image_path = sh.front_image_path,
                            place = sh.place,
                            price = sh.price,
                            readtime = sh.readtime,
                            showname = sh.showname,
                            startime = sh.startime,
                            type = sh.type,
                            url = sh.url
                        };
                List<showstarts> aa = q.ToList();

                foreach (showstarts s in aa)
                {
                    Items.Add(s);
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
                service1 = new ServiceReference1.Service1();
                var keys = service1.GetShow("admin");
                Dictionary<string, showstarts[]> show = new Dictionary<string, showstarts[]>(); //从wcf获取showlist
                foreach (var item in keys)
                {
                    show.Add(item.Key, item.Value);
                }
                //List<showstarts> newshow = new List<showstarts>(show["newshow"]);
                //List<showstarts> oldshow = new List<showstarts>(show["oldshow"]);
                List<showstarts> allShow = new List<showstarts>(show["newshow"]).Union(new List<showstarts>(show["oldshow"])).ToList();
                List<monitor> monitors = new List<monitor>(service1.GetMonitors("admin"));

                var q = from mo in monitors
                        join sh in allShow on
                        mo.actor equals sh.actor
                        //into temp
                        //from tt in temp.DefaultIfEmpty()
                        select new showstarts
                        {
                            actor = sh.actor,
                            front_image_path = sh.front_image_path,
                            place = sh.place,
                            price = sh.price,
                            readtime = sh.readtime,
                            showname = sh.showname,
                            startime = sh.startime,
                            type = sh.type,
                            url = sh.url
                        };
                List<showstarts> aa = q.ToList();

                foreach (showstarts s in aa)
                {
                    Items.Add(s);
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
    }
}
