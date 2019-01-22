using ATicket.DB;
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
    public class DateDValueModel : BaseViewModel
    {
        private NotePadDataAccess dataAccess;
        public ObservableCollection<NotePadItems> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public DateDValueModel(){
            Title = "日期差";
            Items = new ObservableCollection<NotePadItems>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());//load item方法
        }
      
        private async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                this.dataAccess = new NotePadDataAccess();
                var items = dataAccess.GetdNotePadItemsAll();
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
