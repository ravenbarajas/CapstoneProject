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
    public partial class EnterRecipeDetailspt2 : ContentPage
    {
        recipeInfo repository = new recipeInfo();

        public static string recipeID;
        public static string recipeInstructions;
        int counter = 1;

        public EnterRecipeDetailspt2()
        {
            InitializeComponent();
        }

        List<String> instructionsList = new List<string>();
        public void AddEntry_Clicked(object sender, EventArgs a)
        {
            var instruction = new Label();

            instruction.BackgroundColor = Color.FromRgb(214, 215, 215);
            instruction.TextColor = Color.FromRgb(0, 0, 0);
            instruction.Text = counter + ". " + txt_instruction.Text;
            instruction.FontSize = 16;
            instruction.TextTransform = TextTransform.None;
            instruction.Padding = 5;

            EntryFields.Children.Add(instruction);
            counter++;
            string labeltext = "'" + instruction.Text + "'";
            string labeltextArray = lbl_EntryFieldsOutput.Text + labeltext;

            instructionsList.Add(labeltextArray);
            for (int i = 0; i < instructionsList.Count; i++)
            {
                lbl_EntryFieldsOutput.Text = instructionsList[i] + ", ";
            }
            recipeInstructions = lbl_EntryFieldsOutput.Text;

            txt_instruction.Text = "";
        }
        private async void Next_Clicked(object sender, EventArgs e)
        {
            try
            {
                recipeID = generateRecipeID();

                recipeInfoModel recipe = new recipeInfoModel();
                recipe.RecipeID = recipeID;
                recipe.RecipeName = CreateRecipePage.recipeName;
                recipe.RecipeDesc = CreateRecipePage.recipeDesc;

                recipe.RecipeCookTime = EnterRecipeDetailspt1.recipeCookTime;
                recipe.RecipePrepTime = EnterRecipeDetailspt1.recipePrepTime;
                recipe.RecipeTotalTime = EnterRecipeDetailspt1.recipeTotalTime;
                recipe.RecipeCategory = EnterRecipeDetailspt1.recipeCategory;
                recipe.RecipeKeywords = EnterRecipeDetailspt1.recipeKeywords;

                recipe.RecipeInstructions = '[' + recipeInstructions + ']';

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
            catch
            {

            }
        }
        public string generateRecipeID()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
        }
    }
}