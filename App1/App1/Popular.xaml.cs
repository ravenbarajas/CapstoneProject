using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Popular : ContentPage
    {
        public Popular()
        {
            InitializeComponent();
            var Image = new List<string>
            {
                "ga.jpg",
                "ge.jpg",
                "gi.jpg",
                "go.jpg",
                "gu.jpg"
            };
            Carousel2.ItemsSource = Image;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedPage1());
        }
        private async void Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeneratePage());
        }

        private async void Clickedd(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecipePage1());
        }
    }
}