using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.RecipeManagement
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeDetails : ContentPage
    {
        public RecipeDetails(recipeInfoModel recipe)
        {
            InitializeComponent();
            ImageRecipeImage.Source = recipe.RecipeIMG;
            LabelRecipeName.Text = recipe.RecipeName;
            LabelAuthorName.Text = recipe.RecipeAuthor;

            LabelRecipeDesc.Text = recipe.RecipeDescription;

            LabelRecipeCookTime.Text = recipe.RecipeCookTime;
            LabelRecipePrepTime.Text = recipe.RecipePrepTime;

            LabelRecipeInstructions.Text = recipe.RecipeInstructions;
            LabelRecipeIngredients.Text = recipe.RecipeIngredients;
            instructionsGrid.IsVisible = false;
        }

        private void Ingredients_Clicked(object sender, EventArgs e)
        {
            ingredientsGrid.IsVisible = true;
            instructionsGrid.IsVisible = false;

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(56, 115, 246);
            btn.TextColor = Color.FromRgb(255, 255, 255);
            
            btn_instructions.BackgroundColor = Color.FromRgb(255, 255, 255);
            btn_instructions.TextColor = Color.FromRgb(0, 0, 0);
        }
        private void Instructions_Clicked(object sender, EventArgs e)
        {
            ingredientsGrid.IsVisible = false;
            instructionsGrid.IsVisible = true;

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(56, 115, 246);
            btn.TextColor = Color.FromRgb(255, 255, 255);

            btn_ingredients.BackgroundColor = Color.FromRgb(255, 255, 255);
            btn_ingredients.TextColor = Color.FromRgb(0, 0, 0);
        }
    }
}