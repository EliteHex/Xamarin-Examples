using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Examples.Functions
{
    [XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class ControlsPage : ContentPage
    {
        public class ContactMethod
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>
            {
                new ContactMethod { Id = 1, Name = "SMS" },
                new ContactMethod { Id = 2, Name = "Email" }
            };
        }

        private IList<ContactMethod> _contactMethods;
        public ControlsPage()
        {
            InitializeComponent();
            _contactMethods = GetContactMethods();
            foreach(var method in _contactMethods)
            {
                contactMethods.Items.Add(method.Name);
            }
        }

        void Handle_TextChanged(object sender, TextChangedEventArgs e)
        {
            entry_label.Text = e.NewTextValue;
        }

        void Handle_Completed(object sender, System.EventArgs e)
        {
            entry_label.Text = "Completed";
        }

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var name = contactMethods.Items[contactMethods.SelectedIndex];
            _contactMethods.Single(cm => cm.Name == name);
            //DisplayAlert("Selection",contactMethod,"OK");
        }

        void Handle_DateSelected(object sender, DateChangedEventArgs e)
        {
            
        }

    }
}
