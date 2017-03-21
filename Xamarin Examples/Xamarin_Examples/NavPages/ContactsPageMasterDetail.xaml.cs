using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin_Examples.Models;

namespace Xamarin_Examples.NavPages
{
    public partial class ContactsPageMasterDetail : MasterDetailPage
    {
        public ContactsPageMasterDetail()
        {
            InitializeComponent();
            listView.ItemsSource = new List<Contact>
            {
                new Contact { Name = "Ram", ImageUrl="http://lorempixel.com/100/100/people/1/" },
                new Contact { Name = "Mosh", ImageUrl="http://lorempixel.com/100/100/people/2/" }
            };
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            //if (e.SelectedItem == null) return;
            
            var contact = e.SelectedItem as Contact;
            //await Navigation.PushAsync(new ContactDetailPage(contact));
            //listView.SelectedItem = null;

            Detail = new NavigationPage(new ContactDetailPage(contact));
            IsPresented = false;            
        }
    }
}
