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
using System.Collections.ObjectModel;

namespace App1.Views.RecipeGeneration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeOutputPage : ContentPage
    {
        recipeInfo repository = new recipeInfo();
        int itemCount = 0;
        int maxItems = 5;

        public RecipeOutputPage()
        {
            InitializeComponent();
            txt_searchrecipes.Text = $"{Application.Current.Properties["SelectedIngredient1"].ToString()}";
            txt_searchrecipes1.Text = $"{Application.Current.Properties["SelectedIngredient2"].ToString()}";
            txt_searchrecipes2.Text = $"{Application.Current.Properties["SelectedIngredient3"].ToString()}";
            //BindingContext = this;
            RecipeListView.RefreshCommand = new Command(() =>
            {
                OnAppearing();
            });
        }
        List<string> searchTerms = new List<string>();
        protected override async void OnAppearing()
        {
            string searchValue1 = txt_searchrecipes.Text;

            if (!String.IsNullOrEmpty(searchValue1))
            {
                var recipes = await repository.OutputRecipe(searchValue1);
                RecipeListView.ItemsSource = null;
                RecipeListView.ItemsSource = recipes;
                RecipeListView.ItemsSource = recipes.Where(x => x.RecipeIngredients.Contains(searchValue1.ToLower()) && x.RecipeIngredients.ToString().Contains(txt_searchrecipes1.Text.ToLower()) && x.RecipeIngredients.Contains(txt_searchrecipes2.Text.ToLower()));
                RecipeListView.IsRefreshing = false;
            }
            else
            {
                OnAppearing();
            }
        }
        //private async void txt_searchrecipesSearchButtonPressed(object sender, EventArgs e)
        //{
        //    string searchValue1 = "";

        //    if (!String.IsNullOrEmpty(searchValue1))
        //    {
        //        var recipes = await repository.OutputRecipe(searchValue1);
        //        RecipeListView.ItemsSource = null;
        //        RecipeListView.ItemsSource = recipes;
        //        RecipeListView.ItemsSource = recipes.Where(x => x.RecipeIngredients.Contains(searchValue1.ToLower()) && x.RecipeIngredients.ToString().Contains(txt_searchrecipes1.Text.ToLower()) && x.RecipeIngredients.Contains(txt_searchrecipes2.Text.ToLower()));
        //        RecipeListView.IsRefreshing = false;
        //    }
        //    else
        //    {
        //        OnAppearing();
        //    }
        //}
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

        //private async void txt_searchrecipes_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    string searchValue1 = txt_searchrecipes.Text;

        //    if (!String.IsNullOrEmpty(searchValue1))
        //    {
        //        var recipes = await repository.OutputRecipe(searchValue1);
        //        RecipeListView.ItemsSource = null;
        //        RecipeListView.ItemsSource = recipes;
        //        RecipeListView.ItemsSource = recipes.Where(x => x.RecipeIngredients.Contains(searchValue1.ToLower()) && x.RecipeIngredients.ToString().Contains(txt_searchrecipes1.Text.ToLower()) && x.RecipeIngredients.Contains(txt_searchrecipes2.Text.ToLower()));
        //        RecipeListView.IsRefreshing = false;
        //    }
        //    else
        //    {
        //        OnAppearing();
        //    }
        //}

        private void RecipeListView_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            if (itemCount >= maxItems)
            {
                ((ListView)sender).IsVisible = false;
            }
            itemCount++;
        }
    }
}