using ATicket.Models;
using ATicket.Module;
using ATicket.RestApiClent;
using RestSharp;
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
        public ObservableCollection<Monitor> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public MonitorViewModel()
        {
            Title = "歌手";
            Items = new ObservableCollection<Monitor>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());//load item方法
            try {  }
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
                List<Monitor> items = RestHelper.GetMonitor("admin");
                foreach (Monitor item in items)
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
