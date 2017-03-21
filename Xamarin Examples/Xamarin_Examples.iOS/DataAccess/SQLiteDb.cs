using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;
using Xamarin_Examples.iOS.DataAccess;
using System.IO;
using Xamarin_Examples.DataAccess;

[assembly: Dependency(typeof(SQLiteDb))]
namespace Xamarin_Examples.iOS.DataAccess
{
    public class SQLiteDb: ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}
