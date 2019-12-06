using ATicket.Models;
using ATicket.Services;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ATicket.Module;
using ATicket.RestApiClent;

namespace ATicket.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        //private ServiceReference1.Service1 service1;
        public ObservableCollection<show> Items { get; set; }
        public Command LoadItemsCommand { get; set; }
        public HomeViewModel()
        {
            Title = "ATicket";
            Items = new ObservableCollection<show>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());//load item方法

            try
            {
                Dictionary<string,List<Showstarts>> keys = RestHelper.GetShow();
                List<Showstarts> newshow = keys["newShow"];
                List<Showstarts> oldshow = keys["oldShow"];
                newshow = newshow.OrderBy(_x => _x.Startime).ToList();
                oldshow = oldshow.OrderBy(_x => _x.Startime).ToList();

                //类型转换
                //List<show> newShow = new List<show>();
                foreach (Showstarts s in newshow)
                {
                    show t = new show()
                    {
                        Showname = s.Showname,
                        Place = s.Place,
                        Actor = s.Actor,
                        FrontImagePath = s.FrontImagePath,
                        Price = s.Price,
                        Readtime = s.Readtime,
                        Startime = s.Startime,
                        Type = s.Type,
                        Url = s.Url,
                        IsNew = "New"
                    };
                    Items.Add(t);
                }
             
                foreach (Showstarts s in oldshow)
                {
                    show t = new show()
                    {
                        Showname = s.Showname,
                        Place = s.Place,
                        Actor = s.Actor,
                        FrontImagePath = s.FrontImagePath,
                        Price = s.Price,
                        Readtime = s.Readtime,
                        Startime = s.Startime,
                        Type = s.Type,
                        Url = s.Url,
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
                Dictionary<string, List<Showstarts>> keys = RestHelper.GetShow();
                List<Showstarts> newshow = keys["newShow"];
                List<Showstarts> oldshow = keys["oldShow"];
                newshow = newshow.OrderBy(_x => _x.Startime).ToList();
                oldshow = oldshow.OrderBy(_x => _x.Startime).ToList();

                //类型转换
                //List<show> newShow = new List<show>();
                foreach (Showstarts s in newshow)
                {
                    show t = new show()
                    {
                        Showname = s.Showname,
                        Place = s.Place,
                        Actor = s.Actor,
                        FrontImagePath = s.FrontImagePath,
                        Price = s.Price,
                        Readtime = s.Readtime,
                        Startime = s.Startime,
                        Type = s.Type,
                        Url = s.Url,
                        IsNew = "New"
                    };
                    Items.Add(t);
                }
             
                foreach (Showstarts s in oldshow)
                {
                    show t = new show()
                    {
                        Showname = s.Showname,
                        Place = s.Place,
                        Actor = s.Actor,
                        FrontImagePath = s.FrontImagePath,
                        Price = s.Price,
                        Readtime = s.Readtime,
                        Startime = s.Startime,
                        Type = s.Type,
                        Url = s.Url,
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
        public class show: Showstarts
        {
            public string IsNew { set; get; }
        }
    }
}
