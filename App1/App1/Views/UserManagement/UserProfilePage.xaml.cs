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
        userInfo userRepo = new userInfo();
        public UserProfilePage()
        {
            InitializeComponent();
            txt_useremail.Text = $"{Application.Current.Properties["userEmail"].ToString()}";
            UserInfoListView.RefreshCommand = new Command(() =>
            {
                base.OnAppearing();
            });
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
        protected override async void OnAppearing()
        {
            var userdata = await userRepo.UserProfileData(txt_useremail.Text);
            UserInfoListView.ItemsSource = null;
            UserInfoListView.ItemsSource = userdata;
            UserInfoListView.ItemsSource = userdata.Where(x => x.Email.Contains(txt_useremail.Text));
            UserInfoListView.IsRefreshing = false;
        }
    }
}