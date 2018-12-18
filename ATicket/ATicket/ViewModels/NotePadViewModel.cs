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
    public class NotePadViewModel : BaseViewModel
    {
        private NotePadDataAccess dataAccess;
        public ObservableCollection<NotePadItems> Items { get; set; }
        public Command LoadItemsCommand { get; set; }
        public NotePadViewModel()
        {
            Title = "NotaPad";
            Items = new ObservableCollection<NotePadItems>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());//load item方法
            //ExecuteLoadItemsCommand();
        }

        private async Task ExecuteLoadItemsCommand()
        {
            //this.dataAccess = new NotePadDataAccess();
            //Items = new ObservableCollection<NotePadItems>();
            //IEnumerable<NotePadItems> temp = dataAccess.GetdNotePadItemsAll();
            //foreach (NotePadItems a in temp)
            //{
            //    Items.Add(a);
            //}
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
