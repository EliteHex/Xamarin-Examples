using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin_Examples.DataAccess;
using Xamarin_Examples.Functions;
using Xamarin_Examples.NavPages;

namespace Xamarin_Examples
{
    public partial class App : Application
    {
        private const string TitleKey = "Name";
        private const string NotificationsEnabledKey = "NotificationsEnabled";

        public App()
        {
            InitializeComponent();
            //MainPage = new RESTApiPage();

            MainPage = 

            //MainPage = new ListViewPage();
            //MainPage = new NavigationPage(new WelcomePage())
            //{
            //    BarBackgroundColor = Color.Gray,
            //    BarTextColor = Color.White
            //};
            //MainPage = new ContactsPage();
            //MainPage = new NavigationPage(new TablePage());
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

        public string Title
        {
            get
            {
                if(Properties.ContainsKey(TitleKey))
                {
                    return Properties[TitleKey].ToString();
                }
                return "";
            }
            set
            {
                Properties[TitleKey] = value;
            }
        }

        public bool NotificationsEnabled
        {
            get
            {
                if (Properties.ContainsKey(NotificationsEnabledKey))
                {
                    return (bool) Properties[NotificationsEnabledKey];
                }
                return false;
            }
            set
            {
                Properties[NotificationsEnabledKey] = value;
            }
        }
    }
}
