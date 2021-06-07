using System;
using Xamarin.Forms;
using System.IO;
using Xamarin.Forms.Xaml;

namespace Lab4
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "products.db";
        public static ProductRepository database;
        public static ProductRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new ProductRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
