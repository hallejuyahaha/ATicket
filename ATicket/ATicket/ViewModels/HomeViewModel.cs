using ATicket.Models;
using ATicket.Services;
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
        public ObservableCollection<ServiceReference1.showstarts> Items { get; set; }
        public Command LoadItemsCommand { get; set; }
        public HomeViewModel()
        {
            Title = "ATicket";
            Items = new ObservableCollection<ServiceReference1.showstarts>();           
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());//load item方法

            try
            {
                service1 = new ServiceReference1.Service1();
                var items = service1.GetShow();
                foreach (var item in items)
                {
                    Items.Add(item);
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
                var items = service1.GetShow();
                foreach (var item in items)
                {
                    Items.Add(item);
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
