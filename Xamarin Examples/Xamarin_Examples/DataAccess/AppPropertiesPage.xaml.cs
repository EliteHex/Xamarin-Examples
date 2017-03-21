using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xamarin_Examples.DataAccess
{
    public partial class AppPropertiesPage : ContentPage
    {
        public AppPropertiesPage()
        {
            InitializeComponent();
            //if(Application.Current.Properties.ContainsKey(TitleKey))
            //    title.Text = Application.Current.Properties[TitleKey].ToString();
            //if (Application.Current.Properties.ContainsKey(NotificationsEnabledKey))
            //    notificationsEnabled.On = (bool) Application.Current.Properties[NotificationsEnabledKey];

            var app = Application.Current as App;
            BindingContext = Application.Current;


            //title.Text = app.Title;
            //notificationsEnabled.On = app.NotificationsEnabled;
        }

        //void OnChanged(object sender, System.EventArgs e)
        //{
            //var app = Application.Current as App;
            //app.Title = title.Text;
            //app.NotificationsEnabled = notificationsEnabled.On;
            //Application.Current.Properties[TitleKey] = title.Text;
            //Application.Current.Properties[NotificationsEnabledKey] = notificationsEnabled.On;

            //Application.Current.SavePropertiesAsync();
        //}

        protected override void OnDisappearing()
        {
            //navigation away from the page
            base.OnDisappearing();

        }
    }
}
