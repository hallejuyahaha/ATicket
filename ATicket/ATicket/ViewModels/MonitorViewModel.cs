using ATicket.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ATicket.ViewModels
{
    public class MonitorViewModel : BaseViewModel
    {
        private ServiceReference1.Service1 service1;
        public ObservableCollection<ServiceReference1.monitor> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public MonitorViewModel()
        {
            Title = "歌手";
            Items = new ObservableCollection<ServiceReference1.monitor>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());//load item方法
            try { service1 = new ServiceReference1.Service1(); }
            catch (Exception eab) { Debug.WriteLine(eab.Message); }
        }
        private async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();               
                var items = service1.GetMonitors("admin");
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
