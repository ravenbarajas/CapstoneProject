using System;
using App1.Views.RecipeGeneration;
using App1.Views.UserManagement;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.RecipeManagement
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnterRecipeDetailspt3 : ContentPage
    {
        recipeInfo repository = new recipeInfo();
        ingredientInfo ingredientRepository = new ingredientInfo();

        public static string recipeID;
        public static string recipeUnit;
        public static string recipeQty;
        public static string recipeIngredient;
        public static string ingredientWhole;
        public EnterRecipeDetailspt3()
        {
            InitializeComponent();
            lbl_ingredients.Text = "";
            IngredientListView.RefreshCommand = new Command(() =>
            {
                OnAppearing();
            });
            var unit = new List<string>();
            unit.Add("lbs");
            unit.Add("pcs");
            unit.Add("grams");
            unit.Add("cup");
            unit.Add("tbsp");
            unit.Add("tsp");
            unit.Add("ml");

            pk_unit.ItemsSource = unit;
        }
        private async void txt_searchingredients_TextChange(object sender, EventArgs e)
        {
            string searchValue = txt_searchingredient.Text;
            if (!String.IsNullOrEmpty(searchValue))
            {
                var recipes = await ingredientRepository.GetAllByName(searchValue);
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
            var ingredient = await ingredientRepository.GetAll();
            IngredientListView.ItemsSource = null;
            IngredientListView.ItemsSource = ingredient;
            IngredientListView.IsRefreshing = false;

        }
        private void IngredientListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedIngredient = e.Item as Ingredient;

            lbl_ingredients.Text = selectedIngredient.IngredientName;
        }

        private async void Next_Clicked(object sender, EventArgs e)
        {
            try 
            { 
                recipeID = generateRecipeID();

                string ingredientWhole = lbl_EntryFieldsOutput.Text;

                recipeInfoModel recipe = new recipeInfoModel();
                recipe.RecipeIMG = CreateRecipePage.image;
                recipe.RecipeID = recipeID;
                recipe.AuthorName = CreateRecipePage.recipeAuthorName;
                recipe.RecipeName = CreateRecipePage.recipeName;
                recipe.RecipeDesc = CreateRecipePage.recipeDesc;

                recipe.RecipeCookTime = EnterRecipeDetailspt1.recipeCookTime;
                recipe.RecipePrepTime = EnterRecipeDetailspt1.recipePrepTime;
                recipe.RecipeTotalTime = EnterRecipeDetailspt1.recipeTotalTime;
                recipe.RecipeCookingProcess = EnterRecipeDetailspt1.recipePrepProcess;
                recipe.RecipeCategory = EnterRecipeDetailspt1.recipeCategory;
                recipe.RecipeKeywords = EnterRecipeDetailspt1.recipeKeywords;

                recipe.RecipeInstructions = EnterRecipeDetailspt2.recipeInstructions;
                recipe.RecipeIngredientParts = ingredientWhole;

                var response = await DisplayAlert("Confirmation", "Confirm answers?", "Confirm", "Not yet");
                if (response == true)
                {
                    var isSaved = await repository.Save(recipe);
                    if (isSaved)
                    {
                        await DisplayAlert("Information", "Recipe info saved!", "Ok");
                        await Navigation.PushAsync(new UserProfilePage());
                    }
                    else
                    {
                        await DisplayAlert("Error", "Failed to save recipe info!", "Ok");
                    }
                }
                else
                {
                    await DisplayAlert("Error", "Failed to save recipe info!", "Ok");
                }
            }
        catch
        {

        }
    }
        public string generateRecipeID()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
        }
        List<String> ingredientList = new List<string>();
        private async void btn_acceptIngredient_Clicked(object sender, EventArgs e)
        {
            recipeQty = txt_qty.Text;
            recipeUnit = pk_unit.SelectedItem.ToString();
            recipeIngredient = lbl_ingredients.Text;
            
            if (String.IsNullOrEmpty(recipeQty))
            {
                await DisplayAlert("Warning", "Quantity is required", "Ok");
                return;
            }
            if (String.IsNullOrEmpty(recipeUnit))
            {
                await DisplayAlert("Warning", "Unit of Measurement is required", "Ok");
                return;
            }
            if (String.IsNullOrEmpty(recipeIngredient))
            {
                await DisplayAlert("Warning", "Ingredient is required", "Ok");
                return;
            }

            string labeltext = recipeQty +" "+ recipeUnit + " " + recipeIngredient;
            string labeltextArray = lbl_EntryFieldsOutput.Text + labeltext;
            ingredientList.Add(labeltextArray);
            for (int i = 0; i < ingredientList.Count; i++)
            {
                lbl_EntryFieldsOutput.Text = ingredientList[i] + "\n";
            }

            ingredientWhole = lbl_EntryFieldsOutput.Text;

            txt_qty.Text = "";
            lbl_ingredients.Text = "";
        }
    }
}