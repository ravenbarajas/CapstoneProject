using App1.Views.RecipePresentation;
using Newtonsoft.Json;
using System;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        FirebaseClient firebaseClient = new FirebaseClient("https://capstoneproject-b8d68-default-rtdb.asia-southeast1.firebasedatabase.app/");

        ingredientInfo repository = new ingredientInfo();
        recipeInfo recipeoutput = new recipeInfo();

        public static string[] selectedIngredients = new string[3];
        int selectedCount = 0;

        public static string ListOfIngredients;
        public GenerateRecipePage()
        {
            InitializeComponent();
            BindingContext = this;

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
            IngredientListView.ItemsSource = ingredient;
            IngredientListView.IsRefreshing = false;

        }
        List<String> ingredientList = new List<string>();

        ////private void IngredientListView_ItemTapped(object sender, ItemTappedEventArgs e)
        ////{
        ////    var selectedIngredient = e.Item as Ingredient;

        ////    // Set the text of the label to the desired property of the selected item
        ////    var ingredient = new Label();

        ////    ingredient.BackgroundColor = Color.FromRgb(63, 157, 47);
        ////    ingredient.TextColor = Color.FromRgb(255, 255, 255);
        ////    ingredient.Text = selectedIngredient.IngredientName;
        ////    ingredient.FontSize = 16;
        ////    ingredient.TextTransform = TextTransform.None;
        ////    ingredient.HorizontalTextAlignment = TextAlignment.Center;
        ////    ingredient.Padding = 5;

        ////    SelectedIngredients.Children.Add(ingredient);
        ////    string labeltext = ingredient.Text;
        ////}

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

            //var selectedIngredients = IngredientListView.SelectedItem;

            //if (selectedIngredients.Count == 3)
            //{
            //    var ingredient1 = selectedIngredients[0] as Ingredient;
            //    var ingredient2 = selectedIngredients[1] as Ingredient;
            //    var ingredient3 = selectedIngredients[2] as Ingredient;

            //    // Navigate to the next page and pass the selected ingredients
            //    await Navigation.PushAsync(new IngredientsDetailPage(ingredient1, ingredient2, ingredient3));
            //}
            //else
            //{
            //    // Show an error message if the number of selected ingredients is not 3
            //    await DisplayAlert("Error", "Please select exactly 3 ingredients.", "OK");
            //}
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

            //UpdateSelectedIngredients();

            //var selectedItem = e.SelectedItem as Ingredient;
            //if (selectedItem != null)
            //{
            //    var selectedCount = Ingredients.Count(x => x.Selected);
            //    if (selectedCount >= 3 && !selectedItem.Selected)
            //    {
            //        DisplayAlert("Warning", "You can select a maximum of 3 ingredients.", "OK");
            //        IngredientListView.SelectedItem = null;
            //        return;
            //    }
            //    selectedItem.Selected = !selectedItem.Selected;
            //}

        }

        private async void backbutton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
        //private void UpdateSelectedIngredients()
        //{
        //    SelectedIngredientsGrid.Children.Clear();
        //    SelectedIngredientsGrid.RowDefinitions.Clear();
        //    SelectedIngredientsGrid.ColumnDefinitions.Clear();

        //    var selectedIngredients = Ingredients.Where(x => x.Selected);
        //    var row = 0;
        //    var column = 0;
        //    foreach (var ingredient in selectedIngredients)
        //    {
        //        if (column == 0)
        //        {
        //            SelectedIngredientsGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
        //        }
        //        SelectedIngredientsGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
        //        var label = new Label { Text = ingredient.IngredientName };
        //        SelectedIngredientsGrid.Children.Add(label, column, row);
        //        column++;
        //        if (column == 3)
        //        {
        //            column = 0;
        //            row++;
        //        }
        //    }
        //}

    }
}