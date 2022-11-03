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
    public partial class UserProfilePage : ContentPage
    {
        public UserProfilePage()
        {
            InitializeComponent();
        }

        private async void Cookbook_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cookbook());
        }
        private async void Mealplanner_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MealPlanner());
        }
        private async void CreateRecipe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateRecipePage());
        }
    }
}