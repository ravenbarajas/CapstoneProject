using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Views.RecipeManagement;

namespace App1.Views.RecipeGeneration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeOutputPage : ContentPage
    {
        recipeInfo repository = new recipeInfo();
        public RecipeOutputPage()
        {
            InitializeComponent();
            txt_searchrecipes.Text = GenerateRecipePage.ListOfIngredients;
            RecipeListView.RefreshCommand = new Command(() =>
            {
                OnAppearing();
            });
        }
        protected override async void OnAppearing()
        {
            string searchValue = txt_searchrecipes.Text;
            var recipes = await repository.OutputRecipe(searchValue);
            RecipeListView.ItemsSource = null;
            RecipeListView.ItemsSource = recipes;
            RecipeListView.IsRefreshing = false;
        }
        private async void txt_searchrecipesSearchButtonPressed(object sender, EventArgs e)
        {
            //string searchValue = txt_searchrecipes.Text;
            //if (!String.IsNullOrEmpty(searchValue))
            //{
            //    var recipes = await repository.OutputRecipe(searchValue);
            //    RecipeListView.ItemsSource = null;
            //    RecipeListView.ItemsSource = recipes;
            //}
            //else
            //{
            //    OnAppearing();
            //}
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
    }
}