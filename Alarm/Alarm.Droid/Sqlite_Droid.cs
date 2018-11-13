using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using Xamarin.Forms;
using Alarm.Droid;
using System.IO;

[Assembly:Dependency(typeof(Alarm.Droid))]
     namespace Alarm.Droid
{
    public class Sqlite_Droid : Sqlite
    {
       
        public SQLiteConnection getconnection()
        {
            var dbname = "my database.sqlite";
            var dbpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(dbname, dbpath);
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}