
using ATicket.Module;
using ATicket.RestApiClent;
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
        public ObservableCollection<Showstarts> Items { get; set; }
        public Command LoadItemsCommand { get; set; }
        public MineViewModel()
        {
            Title = "我的";
            Items = new ObservableCollection<Showstarts>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());//load item方法

            try
            {
                List<Monitor> monitors = RestHelper.GetMonitor("admin");
                Dictionary<string, List<Showstarts>> show = RestHelper.GetShow();
                List<Showstarts> allShow = show["newShow"].Union(show["oldShow"]).ToList();


                var q = from mo in monitors
                        join sh in allShow on
                        mo.Actor equals sh.Actor
                        select new Showstarts
                        {
                            Actor = sh.Actor,
                            FrontImagePath = sh.FrontImagePath,
                            Place = sh.Place,
                            Price = sh.Price,
                            Readtime = sh.Readtime,
                            Showname = sh.Showname,
                            Startime = sh.Startime,
                            Type = sh.Type,
                            Url = sh.Url
                        };
                List<Showstarts> aa = q.ToList();

                foreach (Showstarts s in aa)
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
                List<Monitor> monitors = RestHelper.GetMonitor("admin");
                Dictionary<string, List<Showstarts>> show = RestHelper.GetShow();
                List<Showstarts> allShow = show["newShow"].Union(show["oldShow"]).ToList();


                var q = from mo in monitors
                        join sh in allShow on
                        mo.Actor equals sh.Actor
                        select new Showstarts
                        {
                            Actor = sh.Actor,
                            FrontImagePath = sh.FrontImagePath,
                            Place = sh.Place,
                            Price = sh.Price,
                            Readtime = sh.Readtime,
                            Showname = sh.Showname,
                            Startime = sh.Startime,
                            Type = sh.Type,
                            Url = sh.Url
                        };
                List<Showstarts> aa = q.ToList();

                foreach (Showstarts s in aa)
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
