using System;
using Xamarin_Examples.DataAccess;
using SQLite;
using System.IO;
using Xamarin.Forms;
using Xamarin_Examples.Droid.DataAccess;

[assembly: Dependency(typeof(SQLiteDb))]
namespace Xamarin_Examples.Droid.DataAccess
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