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
    public partial class Discover : ContentPage
    {
        public Discover()
        {
            InitializeComponent();
            var Image2 = new List<string>
            {
                "ge.jpg",
                "ga.jpg",
                "hi.jpg",
                "he.jpg",
                "ha.jpg",
                "ri.jpg",
                "re.jpg",
                "ra.jpg"
            };
            var Image = new List<string>
            {
                "ha.jpg",
                "he.jpg",
                "hi.jpg",
                "ho.jpg",
                "hu.jpg"
            };
            Carousel1.ItemsSource = Image;
            
        }

        private async void BuClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedPage1());
        }

        private async void BuClicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeneratePage());
        }

        private async void BuClicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecipePage1());
        }
    }
    }
