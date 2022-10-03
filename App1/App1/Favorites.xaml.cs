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
    public partial class Favorites : ContentPage
    {
        public Favorites()
        {
            InitializeComponent();
            var Image = new List<string>
            {
                "ra.jpg",
                "re.jpg",
                "ri.jpg"
            };
            Carousel3.ItemsSource = Image;
        }

        private async void BClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedPage1());
        }

        private async void BClicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeneratePage());
        }
        private async void BClicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecipePage1());
        }
    }
}