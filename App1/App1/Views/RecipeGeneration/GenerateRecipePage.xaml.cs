using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.RecipeGeneration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GenerateRecipePage : ContentPage
    {
        ingredientInfo repository = new ingredientInfo();
        recipeInfo recipeoutput = new recipeInfo();
        public static string ListOfIngredients;
        public GenerateRecipePage()
        {
            InitializeComponent();
            IngredientListView.RefreshCommand = new Command(() =>
            {
                OnAppearing();
            });
            //var RecipeType = new List<string>();
            //RecipeType.Add("Easy");
            //RecipeType.Add("Meat");
            //RecipeType.Add("Vegetable");
            //RecipeType.Add("Healthy");
            //RecipeType.Add("Low Cholesterol");
            //RecipeType.Add("Low Sugar");
            //RecipeType.Add("Low Sodium");
            //RecipeType.Add("Beginner Cook");
            //RecipeType.Add("Chicken");
            //RecipeType.Add("Dessert");

            //pk_recipetype.ItemsSource = RecipeType;
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
        private void IngredientListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedIngredient = e.Item as Ingredient;

            // Set the text of the label to the desired property of the selected item
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
            string labeltextArray = lbl_EntryFieldsOutput.Text + labeltext;

            ingredientList.Add(labeltextArray);
            for (int i = 0; i < ingredientList.Count; i++)
            {
                lbl_EntryFieldsOutput.Text = ingredientList[i] /*+ "\n"*/;
            }
        }

        private async void Generate_Clicked(object sender, EventArgs e)
        {
            try
            {
                ListOfIngredients = lbl_EntryFieldsOutput.Text;

                await Navigation.PushAsync(new RecipeOutputPage());
            }
            catch
            {

            }
        }
    }
}