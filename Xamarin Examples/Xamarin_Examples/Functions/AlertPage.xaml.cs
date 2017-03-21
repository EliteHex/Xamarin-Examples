using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xamarin_Examples.Functions
{
    public partial class AlertPage : ContentPage
    {
        public AlertPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            //var response = await DisplayAlert("Warning", "Are you sure?", "Yes", "No");
            //if (response)
            //    await DisplayAlert("Done", "Response Saved.", "OK");

            var response = await DisplayActionSheet("Title","Cancel","Delete",
                "Copy Link", "Message", "Email");

            await DisplayAlert("Response", response, "OK");
        }
    }
}
