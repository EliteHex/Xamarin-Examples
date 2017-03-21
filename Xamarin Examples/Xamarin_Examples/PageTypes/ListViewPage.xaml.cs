using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin_Examples.Models;

namespace Xamarin_Examples
{
    public partial class ListViewPage : ContentPage
    {
        private ObservableCollection<Contact> _contacts;
        ObservableCollection<Contact> GetContacts()
        {
            _contacts = new ObservableCollection<Contact>
            {
                new Contact { Name = "Ram", ImageUrl="http://lorempixel.com/100/100/people/1/" },
                new Contact { Name = "Mosh", ImageUrl="http://lorempixel.com/100/100/people/2/",Status = "Hey, let's talk!" }
            };
            return _contacts;
        }

        public ListViewPage()
        {
            InitializeComponent();
            //var names = new List<string>
            //{
            //    "Ram",
            //    "Mosh",
            //    "Bob"
            //};

            listView.ItemsSource = GetContacts();

            //listView.ItemsSource = new List<ContactGroup>
            //{
            //    new ContactGroup("R","R")
            //    {
            //        new Contact { Name = "Ram", ImageUrl="http://lorempixel.com/100/100/people/1/" }
            //    },
            //    new ContactGroup("M","M")
            //    {
            //        new Contact { Name = "Mosh", ImageUrl="http://lorempixel.com/100/100/people/2/",Status = "Hey, let's talk!" }
            //    }

            //};            
        }

        void Call_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "OK");
        }
        void Delete_Clicked(object sender, System.EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            //DisplayAlert("Delete", contact.Name, "OK");
            _contacts.Remove(contact);
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            //listView.SelectedItem = null;
            var contact = e.SelectedItem as Contact;
            //DisplayAlert("Selected", contact.Name,"OK");
        }

        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            //DisplayAlert("Tapped", contact.Name, "OK");
        }

        void Handle_Refresh(object sender, System.EventArgs e)
        {
            listView.ItemsSource = GetContacts();
            listView.EndRefresh();
        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(e.NewTextValue))
            {
                listView.ItemsSource = _contacts;
            }
            else
            {
                listView.ItemsSource = _contacts.Where(item => item.Name.StartsWith(e.NewTextValue));
            }
            
        }
    }
}
