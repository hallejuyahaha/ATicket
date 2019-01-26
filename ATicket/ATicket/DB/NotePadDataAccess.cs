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
    public class NotePadDataAccess
    {
        private SQLiteConnection database;
        private static object collisionLock = new object();
        public ObservableCollection<NotePadItems> NotePadItems { set; get; }
        public NotePadDataAccess()
        {
            database = DependencyService.Get<IDataBaseConnection>().DbConnection();
            database.CreateTable<NotePadItems>();
            this.NotePadItems = new ObservableCollection<NotePadItems>(database.Table<NotePadItems>());

            if(!database.Table<NotePadItems>().Any())
            {
                this.NotePadItems.Add(new Models.NotePadItems {
                    Content = "content",
                    Id = 1,
                    NTitle = "title",
                    Time = DateTime.Now
                });
            }
        }

        //使用linq查询
        public IEnumerable<NotePadItems> GetFilteredNotePadItems(string title)
        {
            // 锁定数据库，以防冲突
            lock (collisionLock)
            {
                var query = from aa in database.Table<NotePadItems>()
                            where aa.NTitle == title
                            select aa;
                return query.AsEnumerable();
            }
        }
        public IEnumerable<NotePadItems> GetdNotePadItemsAll()
        {
            // 锁定数据库，以防冲突
            lock (collisionLock)
            {
                var query = from aa in database.Table<NotePadItems>()
                          
                            select aa;
                return query.AsEnumerable();
            }
        }
        public IEnumerable<NotePadItems> GetdNotePadItemsByTime(DateTime start, DateTime end)
        {
            // 锁定数据库，以防冲突
            lock (collisionLock)
            {
                var query = from aa in database.Table<NotePadItems>()
                            where aa.Time>=start && aa.Time <= end
                            select aa;
                return query.AsEnumerable();
            }
        }
        //使用sql语句查询
        public IEnumerable<NotePadItems> GetFilteredNotePadItemsAll()
        {
            lock (collisionLock)
            {
                return database.Query<NotePadItems>("SELECT * FROM NotePadItems").AsEnumerable();
            }
        }

        //根据id查询获取数据
        public NotePadItems GetNotePadItem(int id)
        {
            lock (collisionLock)
            {
                return database.Table<NotePadItems>().FirstOrDefault(_x => _x.Id == id);
            }
        }

        //保存一条数据到数据库，判断ID是否为0，如果为0，在数据库中新增一条记录，如果不为0，表示数据库中已有该条记录，直接更新
        public int SaveNotePadItems(NotePadItems items)
        {
            lock (collisionLock)
            {
                if (items.Id != 0)
                {
                    database.Update(items);
                    return items.Id;
                }
                else
                {
                    database.Insert(items);
                    return items.Id;
                }
            }
        }

        //保存所有的数据到数据库，判断id是否为0，如果为0，在数据库中增加一条记录，如果不为0，表示已有，直接更新
        public void SaveAllNotePadItems()
        {
            lock (collisionLock)
            {
                foreach (var item in this.NotePadItems)
                {
                    if (item.Id != 0)
                    {
                        database.Update(item);
                    }
                    else
                    {
                        database.Insert(item);
                    }
                }
            }
        }

        //删除一条数据，判断id是否为0 如果为0 表示数据不存在，
        public int DeleteNotePadItems(NotePadItems items)
        {
            var id = items.Id;
            if (id != 0)
            {
                lock (collisionLock)
                {
                    database.Delete<NotePadItems>(id);
                }
            }
            this.NotePadItems.Remove(items);
            return id;
        }
    }
}
