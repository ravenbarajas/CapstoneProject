using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        private void IngredientGroup_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(63, 157, 47);
            btn.TextColor = Color.White;
            btn.BorderWidth = 0;
        }

        private void txt_search_SearchButtonPressed(object sender, EventArgs e)
        {

        }
    }
}