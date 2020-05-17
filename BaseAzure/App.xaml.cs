using BaseAzure.Data;
using BaseAzure.Service;
using BaseAzure.View;
using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaseAzure
{
    public partial class App : Application
    {
        private static ContactsDatabase database;

        public static ContactsDatabase Database
        {
            get
            {
                if (database == null)
                {
                    try
                    {
                        database =
                            new ContactsDatabase(DependencyService
                                .Get<IFileHelper>()
                                .GetLocalFilePath("contactsdb.db3"));
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ContactsPage());

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
