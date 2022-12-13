using App1.Views.RecipeGeneration;
using App1.Views.UserManagement;
using App1.Views.RecipeManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.RecipePresentation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        recipeInfo repository = new recipeInfo();
        public HomePage()
        {
            InitializeComponent();
            RecipeListView.RefreshCommand = new Command(() =>
            {
                OnAppearing();
            });

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
            await Navigation.PushAsync(new PreferenceSelectionPage());
        }
        private async void Recipe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecipePage());
        }
        private void highlightMT()
        {
            MT1.BackgroundColor = Color.FromRgb(127, 132, 135);
            MT1.TextColor = Color.White;
            MT1.FontAttributes = FontAttributes.None;

            MT2.BackgroundColor = Color.FromRgb(127, 132, 135);
            MT2.TextColor = Color.White;
            MT2.FontAttributes = FontAttributes.None;

            MT3.BackgroundColor = Color.FromRgb(127, 132, 135);
            MT3.TextColor = Color.White;
            MT3.FontAttributes = FontAttributes.None;

            MT4.BackgroundColor = Color.FromRgb(127, 132, 135);
            MT4.TextColor = Color.White;
            MT4.FontAttributes = FontAttributes.None;

            MT5.BackgroundColor = Color.FromRgb(127, 132, 135);
            MT5.TextColor = Color.White;
            MT5.FontAttributes = FontAttributes.None;

            MT6.BackgroundColor = Color.FromRgb(127, 132, 135);
            MT6.TextColor = Color.White;
            MT6.FontAttributes = FontAttributes.None;

            MT7.BackgroundColor = Color.FromRgb(127, 132, 135);
            MT7.TextColor = Color.White;
            MT7.FontAttributes = FontAttributes.None;

            MT8.BackgroundColor = Color.FromRgb(127, 132, 135);
            MT8.TextColor = Color.White;
            MT8.FontAttributes = FontAttributes.None;
        }
        private void MT_Clicked(object sender, EventArgs e)
        {
            highlightMT();

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.FontAttributes = FontAttributes.Bold;
            btn.BorderWidth = 0;
        }
        private async void RecipeImg_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecipeOutputPage());
        }

        protected override async void OnAppearing()
        {
            var recipes = await repository.GetAll();
            RecipeListView.ItemsSource = null;
            RecipeListView.ItemsSource = recipes;
            RecipeListView.IsRefreshing = false;

        }
        private void RecipeListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
            {
                return;
            }
            var recipes = e.Item as recipeInfoModel;
            Navigation.PushModalAsync(new RecipeDetails(recipes));
            ((ListView)sender).SelectedItem = null;

        }
        private async void txt_searchrecipesSearchButtonPressed(object sender, EventArgs e)
        {
            string searchValue = txt_searchrecipes.Text;
            if (!String.IsNullOrEmpty(searchValue))
            {
                var recipes = await repository.GetAllByName(searchValue);
                RecipeListView.ItemsSource = null;
                RecipeListView.ItemsSource = recipes;
            }
            else 
            {
                OnAppearing();
            }
        }


    }
}