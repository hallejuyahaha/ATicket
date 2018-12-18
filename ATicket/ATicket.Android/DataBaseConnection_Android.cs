using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ATicket.DB;
using ATicket.Droid;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(DataBaseConnection_Android))]  //注册入depengdenService   必须加上这句话，才会被调用
namespace ATicket.Droid
{   
    public class DataBaseConnection_Android : IDataBaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName="ATicket.db3";
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),dbName);
            return new SQLiteConnection(path);
        }
    }
}