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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void Home_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
        private async void UserProfile_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserProfilePage());
        }
        private async void GenerateRecipe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeneratePage());
        }
        private async void DiscoverPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DiscoverPage());
        }
        private async void PopularPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PopularPage());
        }
        private async void FavoritePage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FavoritePage());
        }
    }
}