using System;
using App1.Views.RecipeGeneration;
using App1.Views.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Essentials;
using Firebase.Storage;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System.IO;

namespace App1.Views.RecipeManagement
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnterRecipeDetailspt2 : ContentPage
    {
        MediaFile file;
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
            string labeltext =  instruction.Text;
            string labeltextArray = lbl_EntryFieldsOutput.Text + labeltext;

            instructionsList.Add(labeltextArray);
            for (int i = 0; i < instructionsList.Count; i++)
            {
                lbl_EntryFieldsOutput.Text = instructionsList[i] + "\n";
            }
            recipeInstructions = lbl_EntryFieldsOutput.Text;

            txt_instruction.Text = "";
        }
        private async void Next_Clicked(object sender, EventArgs e)
        {
            try
            {
                recipeInstructions = lbl_EntryFieldsOutput.Text;

                await Navigation.PushAsync(new EnterRecipeDetailspt3());
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