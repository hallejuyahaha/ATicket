using ATicket.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace ATicket.DB
{
    public class SqliteHelper<T>
    {
        private SQLiteConnection database;
        private static object collisionLock = new object();
        public ObservableCollection<T> NotePadItems { set; get; }
        public SqliteHelper()
        {
            database = DependencyService.Get<IDataBaseConnection>().DbConnection();
            database.CreateTable<T>();
            

            //if (!database.Table<T>().Any())
            {
            //    this.NotePadItems.Add(new Models.NotePadItems
            //    {
            //        Content = "content",
            //        Id = 1,
            //        NTitle = "title",
            //        Time = DateTime.Now
            //    });
            }
        }
    }
}
