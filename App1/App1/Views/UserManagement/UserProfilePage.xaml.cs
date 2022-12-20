using App1.Views.RecipeManagement;
using App1.Views.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.UserManagement
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserProfilePage : ContentPage
    {
        public UserProfilePage()
        {
            InitializeComponent();

            //txt_userprofilename.Text = UserInfoPage.username;
        }
        private async void Cookbook_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CookbookPage());
        }
        private async void Mealplanner_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MealplannerPage());
        }
        private async void CreateRecipe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateRecipePage());
        }
    }
}