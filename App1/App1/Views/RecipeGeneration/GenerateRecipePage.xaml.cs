using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.RecipeGeneration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GenerateRecipePage : ContentPage
    {
        ingredientInfo repository = new ingredientInfo();
        recipeInfo recipeoutput = new recipeInfo();

        public static string[] selectedIngredients = new string[3];
        int selectedCount = 0;

        public static string ListOfIngredients;
        public GenerateRecipePage()
        {
            InitializeComponent();
            IngredientListView.RefreshCommand = new Command(() =>
            {
                OnAppearing();
            });
        }
        private async void txt_searchingredients_TextChange(object sender, EventArgs e)
        {
            string searchValue = txt_searchingredient.Text;
            if (!String.IsNullOrEmpty(searchValue))
            {
                var recipes = await repository.GetAllByName(searchValue);
                IngredientListView.ItemsSource = null;
                IngredientListView.ItemsSource = recipes;
            }
            else
            {
                OnAppearing();
            }
        }
        protected override async void OnAppearing()
        {
            var ingredient = await repository.GetAll();
            IngredientListView.ItemsSource = null;
            IngredientListView.ItemsSource = ingredient;
            IngredientListView.IsRefreshing = false;

        }
        List<String> ingredientList = new List<string>();
        //private void IngredientListView_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    var selectedIngredient = e.Item as Ingredient;

        //    // Set the text of the label to the desired property of the selected item
        //    var ingredient = new Label();

        //    ingredient.BackgroundColor = Color.FromRgb(63, 157, 47);
        //    ingredient.TextColor = Color.FromRgb(255, 255, 255);
        //    ingredient.Text = selectedIngredient.IngredientName;
        //    ingredient.FontSize = 16;
        //    ingredient.TextTransform = TextTransform.None;
        //    ingredient.HorizontalTextAlignment = TextAlignment.Center;
        //    ingredient.Padding = 5;

        //    SelectedIngredients.Children.Add(ingredient);
        //    string labeltext = ingredient.Text;
        //}

        private async void Generate_Clicked(object sender, EventArgs e)
        {
            try
            {
                //ListOfIngredients = lbl_EntryFieldsOutput.Text;
                //await Navigation.PushAsync(new RecipeOutputPage(selectedIngredients));
                await Navigation.PushAsync(new RecipeLoadingPage(selectedIngredients));
            }
            catch
            {

            }
        }

        private void IngredientListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (selectedCount < 3)
            {
                var selectedIngredient = e.SelectedItem as Ingredient;
                var ingredient = new Label();

                ingredient.BackgroundColor = Color.FromRgb(63, 157, 47);
                ingredient.TextColor = Color.FromRgb(255, 255, 255);
                ingredient.Text = selectedIngredient.IngredientName;
                ingredient.FontSize = 16;
                ingredient.TextTransform = TextTransform.None;
                ingredient.HorizontalTextAlignment = TextAlignment.Center;
                ingredient.Padding = 5;

                SelectedIngredients.Children.Add(ingredient);
                string labeltext = ingredient.Text;

                var selectedIngredientInputs = e.SelectedItem as Ingredient;
                selectedIngredients[selectedCount] = selectedIngredientInputs.IngredientName;
                selectedCount++;
            }
            else
            {
                DisplayAlert("Notice", "Woah! Take it easy. You only need 3 ingredients to start", "Ok");
                IngredientListView.IsEnabled = false;
                selectedCount--;

                return;
            }
        }
    }
}