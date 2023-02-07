using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Views.RecipePresentation;
using App1.Views.RecipeGeneration;
using System.Collections.ObjectModel;

namespace App1.Views.RecipePresentation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeOutputPage : ContentPage
    {
        recipeInfo repository = new recipeInfo();
        int itemCount = 0;
        int maxItems = 5;

        FirebaseClient firebaseClient = new FirebaseClient("https://capstoneproject-b8d68-default-rtdb.asia-southeast1.firebasedatabase.app/");
        FirebaseStorage firebaseStorage = new FirebaseStorage("capstoneproject-b8d68.appspot.com");
        public RecipeOutputPage()
        {
            InitializeComponent();
            ////txt_searchrecipes.Text = $"{Application.Current.Properties["SelectedIngredient1"].ToString()}";
            ////txt_searchrecipes1.Text = $"{Application.Current.Properties["SelectedIngredient2"].ToString()}";
            ////txt_searchrecipes2.Text = $"{Application.Current.Properties["SelectedIngredient3"].ToString()}";
            ingredient1.Text = $"{Application.Current.Properties["SelectedIngredient1"].ToString()}";
            ingredient2.Text = $"{Application.Current.Properties["SelectedIngredient2"].ToString()}";
            ingredient3.Text = $"{Application.Current.Properties["SelectedIngredient3"].ToString()}";

            //BindingContext = this;
            RecipeListView.RefreshCommand = new Command(() =>
            {
                OnAppearing();
                RecipeListView.IsRefreshing = false;
            });
        }
        List<string> searchTerms = new List<string>();
        protected override async void OnAppearing()
        {
            //base.OnAppearing();
            //RecipeListView.IsRefreshing = false;

            //string searchValue1 = txt_searchrecipes?.Text ??"Null Value";
            //string searchValue2 = txt_searchrecipes1?.Text ?? "Null Value";
            //string searchValue3 = txt_searchrecipes2?.Text ?? "Null Value";


            //if (!String.IsNullOrEmpty(ingredient1.Text))
            //{
            //    var recipes = await repository.OutputRecipe(ingredient1.Text.ToLower());
            //    RecipeListView.ItemsSource = null;
            //    RecipeListView.ItemsSource = recipes;
            //    RecipeListView.ItemsSource = recipes.Where(x => x.RecipeIngredients.Contains(ingredient2.Text.ToLower()) /*&& x.RecipeIngredients.Contains(searchValue3.ToLower())*/ /*&& x.RecipeIngredients.Contains(txt_searchrecipes.Text.ToLower()) && x.RecipeIngredients.Contains(txt_searchrecipes2.Text.ToLower())*/);
            //    RecipeListView.ItemsSource = recipes.Where(x => x.RecipeIngredients.Contains(ingredient3.Text.ToLower()) /*&& x.RecipeIngredients.Contains(txt_searchrecipes1.Text.ToLower()) && x.RecipeIngredients.Contains(txt_searchrecipes.Text.ToLower())*/);
            //    RecipeListView.IsRefreshing = false;
            //}
            //else
            //{
            //    OnAppearing();
            //}

            //var recipeOutput = await firebaseClient
            //      .Child(nameof(recipeInfoModel))
            //      .OnceAsync<recipeInfoModel>();

            //recipes.Add(recipeOutput);
            //RecipeListView.ItemsSource = recipes;
            try
            {
                string searchValue = ingredient1.Text;
                var recipes = await repository.OutputRecipe(searchValue);
                RecipeListView.ItemsSource = null;
                RecipeListView.ItemsSource = recipes;
                RecipeListView.IsRefreshing = false;
            }
            catch (Exception exception)
            {
                DisplayAlert("Error", exception.Message, "Ok");
            }
        }
        //private async void txt_searchrecipesSearchButtonPressed(object sender, EventArgs e)
        //{
        //    //    string searchValue1 = "";

        //    //    if (!String.IsNullOrEmpty(searchValue1))
        //    //    {
        //    //        var recipes = await repository.OutputRecipe(searchValue1);
        //    //        RecipeListView.ItemsSource = null;
        //    //        RecipeListView.ItemsSource = recipes;
        //    //        RecipeListView.ItemsSource = recipes.Where(x => x.RecipeIngredients.Contains(searchValue1.ToLower()) && x.RecipeIngredients.ToString().Contains(txt_searchrecipes1.Text.ToLower()) && x.RecipeIngredients.Contains(txt_searchrecipes2.Text.ToLower()));
        //    //        RecipeListView.IsRefreshing = false;
        //    //    }
        //    //    else
        //    //    {
        //    //        OnAppearing();
        //    //    }
        //    //}

        //    //private async void RefreshListView()
        //    //{
        //    //    string searchValue1 = txt_searchrecipes.Text;
        //    //    string searchValue2 = txt_searchrecipes1.Text;
        //    //    string searchValue3 = txt_searchrecipes2.Text;

        //    //    var recipes = await repository.OutputRecipe(searchValue1.ToLower());
        //    //    RecipeListView.ItemsSource = null;
        //    //    RecipeListView.ItemsSource = recipes;
        //    //    RecipeListView.ItemsSource = recipes.Where(x => x.RecipeIngredients.Contains(searchValue2.ToLower()) && x.RecipeIngredients.Contains(searchValue3.ToLower()) /*&& x.RecipeIngredients.Contains(txt_searchrecipes.Text.ToLower()) && x.RecipeIngredients.Contains(txt_searchrecipes2.Text.ToLower())*/);
        //    //    //RecipeListView.ItemsSource = recipes.Where(x => x.RecipeIngredients.Contains(searchValue3.ToLower()) /*&& x.RecipeIngredients.Contains(txt_searchrecipes1.Text.ToLower()) && x.RecipeIngredients.Contains(txt_searchrecipes.Text.ToLower())*/);
        //    //    RecipeListView.IsRefreshing = false;

        //    //var recipeOutput = await repository.OutputRecipe(ingredient1?.Text);
        //    //RecipeListView.ItemsSource = null;
        //    //RecipeListView.ItemsSource = recipeOutput;
        //    //RecipeListView.IsRefreshing = false;
        //}
        private void RecipeListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
            {
                return;
            }
            var recipes = e.Item as recipeInfoModel;
            Navigation.PushAsync(new RecipeDetailsPage(recipes));
            ((ListView)sender).SelectedItem = null;
            //RefreshListView();
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
        private async void Generate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GenerateRecipePage());
        }
    }
}