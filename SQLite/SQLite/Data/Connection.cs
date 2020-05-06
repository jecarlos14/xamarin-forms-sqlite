using System;
using System.Collections.Generic;
using System.Text;

namespace SQLite.Data
{
    public static class Connection
    {
        private static SQLiteAsyncConnection database;
        public static SQLiteAsyncConnection GetConnection()
        {
            return database;
        }

        public static void Register(string v)
        {
            database = new SQLiteAsyncConnection(v);
        }
    }
}
