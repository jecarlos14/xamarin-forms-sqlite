using SQLite.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLite
{
    public partial class App : Application
    {
        private static SQLiteAsyncConnection database;
        public App()
        {
            InitializeComponent();

            Connection.Register(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SQLite.db3"));

            MainPage = new MainPage();
        }

        public static SQLiteAsyncConnection DataBase
        {
            get
            {
                if (database == null)
                {
                    database = new SQLiteAsyncConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SQLite.db3"));
                }

                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
