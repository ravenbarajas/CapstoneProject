using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static App1.RecipInfo;

namespace App1.Views.RecipeGeneration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeOutputPage : ContentPage
    {
        RecipInfo recipeoutput = new RecipInfo();
        public RecipeOutputPage()
        {
            InitializeComponent();
        }
        private async void SearchButton_Clicked(object sender, EventArgs e)
        {
            var ingredientsList = IngredientsEntry.Text;
            List<Recipe> recipes = await recipeoutput.GetRecipesByIngredients(ingredientsList);
        }
    }
}