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

        public static string recipeID;

        public EnterRecipeDetailspt3()
        {
            InitializeComponent();
        }
        private async void Next_Clicked(object sender, EventArgs e)
        {
            recipeID = generateRecipeID();

            recipeInfoModel recipe = new recipeInfoModel();
            recipe.RecipeID = recipeID;
            recipe.RecipeName = CreateRecipePage.recipeName;
            recipe.RecipeDesc = CreateRecipePage.recipeDesc;

            var response = await DisplayAlert("Confirmation", "Confirm answers?", "Confirm", "Not yet");
            if (response == true)
            {
                var isSaved = await repository.Save(recipe);
                if (isSaved)
                {
                    await DisplayAlert("Information", "User recipe saved!", "Ok");
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
        public string generateRecipeID()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
        }
    }
}