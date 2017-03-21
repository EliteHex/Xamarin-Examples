using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Examples
{
    [XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
            slider.Value = 0.5;

            Padding = Device.OnPlatform(iOS: new Thickness(0, 20, 0, 0),
                                        Android: new Thickness(10, 20, 0, 0),
                                        WinPhone: new Thickness(30, 20, 0, 0));

            Device.OnPlatform(iOS: () => { Padding = new Thickness(0, 20, 0, 0); },
                           Android: ()=> { Padding = new Thickness(10, 20, 0, 0); }
            );

            //var x = new OnPlatform<Thickness>
            //{
            //    Android = new Thickness(10, 20, 0, 0),
            //    iOS = new Thickness(0, 20, 0, 0)
            //};
        }

        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            //label.Text = String.Format("Value is {0:F2}",e.NewValue);
        }
    }
}
