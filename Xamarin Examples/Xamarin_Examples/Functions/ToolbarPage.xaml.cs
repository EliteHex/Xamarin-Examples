using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xamarin_Examples.Functions
{
    public partial class ToolbarPage : ContentPage
    {
        public ToolbarPage()
        {
            InitializeComponent();
        }

        async void Handle_Activated(object sender, System.EventArgs e)
        {
            await DisplayAlert("Activated", "ToolbarItem Activated","OK");
        }
    }
}
