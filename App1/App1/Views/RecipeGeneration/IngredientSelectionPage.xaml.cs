using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Views.RecipeGeneration;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.RecipeGeneration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IngredientSelectionPage : ContentPage
    {
        public IngredientSelectionPage()
        {
            InitializeComponent();
            List<IngredientInfoModel> ingredientsListView = new List<IngredientInfoModel>
            {

            };
            ingredientsList.ItemsSource = ingredientsListView;
        }

        private void IngredientGroup_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }
        private void srcbr_ingredients_TextChanged(object sender, TextChangedEventArgs e)
        {
            //ingredientsList.ItemsSource = ingredientsListView.Where(s=> s.IngredientName.StartsWith(e.NewTextValue));
        }
    }
}