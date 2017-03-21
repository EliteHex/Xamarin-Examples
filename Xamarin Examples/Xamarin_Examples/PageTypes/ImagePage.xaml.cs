using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xamarin_Examples
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            //var imageSource = (UriImageSource) ImageSource.FromUri(new Uri("http://...."));

            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            imageSource.CachingEnabled = false;
            //imageSource.CacheValidity = TimeSpan.FromHours(1); //default 24 hours

            //image.Source = imageSource; //implicit conversion
            //image.Source = ImageSource.FromResource("Xamarin_Hello_World.Images.background.jpg");
            btn.Image = (FileImageSource) ImageSource.FromFile(
                Device.OnPlatform(iOS: "clock.png", 
                                  Android: "clock.png",
                                  WinPhone: "Images/clock.png")                
                );
        }
    }
}
