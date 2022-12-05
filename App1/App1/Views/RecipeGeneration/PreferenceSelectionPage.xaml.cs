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
    public partial class PreferenceSelectionPage : ContentPage
    {
        public PreferenceSelectionPage()
        {
            InitializeComponent();

            var cookprocess = new List<string>();
            cookprocess.Add("Fried");
            cookprocess.Add("Baked");
            cookprocess.Add("Grilled");
            cookprocess.Add("Steamed");

            pk_cookprocess.ItemsSource = cookprocess;
            lbl_cookprocess.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_cookprocess));

            var mainingredient = new List<string>();
            mainingredient.Add("Pork");
            mainingredient.Add("Beef");
            mainingredient.Add("Chicken");
            mainingredient.Add("Seafood");
            mainingredient.Add("Vegetable");
            mainingredient.Add("Bread");
            mainingredient.Add("Grain");

            pk_mainingredient.ItemsSource = mainingredient;
            lbl_mainingredient.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_mainingredient));

            var taste = new List<string>();
            taste.Add("Sweet");
            taste.Add("Sour");
            taste.Add("Spicy");
            taste.Add("Umami");

            pk_taste.ItemsSource = taste;
            lbl_taste.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_taste));

            var difficulty = new List<string>();
            difficulty.Add("Simple (1 - 3)");
            difficulty.Add("Easy (4 - 5)");
            difficulty.Add("Average (6 - 8)");
            difficulty.Add("Hard (9 - 10)");

            pk_difficulty.ItemsSource = difficulty;
            lbl_difficulty.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_difficulty));

            lbl_cookprocess.IsVisible = false;
            lbl_mainingredient.IsVisible = false;
            lbl_taste.IsVisible = false;
            lbl_difficulty.IsVisible = false;
        }
        private void btnshow1(object sender, EventArgs e)
        {
            lbl_cookprocess.IsVisible = true;
        }
        private void btnshow2(object sender, EventArgs e)
        {
            lbl_mainingredient.IsVisible = true;
        }
        private void btnshow3(object sender, EventArgs e)
        {
            lbl_taste.IsVisible = true;
        }
        private void btnshow4(object sender, EventArgs e)
        {
            lbl_difficulty.IsVisible = true;
        }
        private async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IngredientSelectionPage());
        }
    }
}