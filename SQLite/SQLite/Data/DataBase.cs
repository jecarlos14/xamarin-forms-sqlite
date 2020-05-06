using SQLite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLite.Data
{
    public class DataBase
    {
        protected readonly SQLiteAsyncConnection database;

        public DataBase()
        {
            database = //Connection.GetConnection();
                App.DataBase;
        }
    }
}
