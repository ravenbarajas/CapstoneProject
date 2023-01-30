using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.RecipeGeneration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeLoadingPage : ContentPage
    {
        public string[] Ingredients { get; set; }
        public RecipeLoadingPage(string[] ingredients)
        {
            InitializeComponent();
            Ingredients = ingredients;
            BindingContext = this;
            OnAppearing();
        }
        protected override async void OnAppearing()
        {
            await Task.Delay(250);
            message1.TextColor = Color.FromRgb(56, 115, 246);
            message1.BackgroundColor = Color.Transparent;
            message2.TextColor = Color.Transparent;
            message2.BackgroundColor = Color.Transparent;
            message3.TextColor = Color.Transparent;
            message3.BackgroundColor = Color.Transparent;
            await Task.Delay(2000);
            message1.TextColor = Color.Transparent;
            message1.BackgroundColor = Color.Transparent;
            message2.TextColor = Color.FromRgb(56, 115, 246);
            message2.BackgroundColor = Color.Transparent;
            message3.TextColor = Color.Transparent;
            message3.BackgroundColor = Color.Transparent;
            await Task.Delay(1500);
            message1.TextColor = Color.Transparent;
            message1.BackgroundColor = Color.Transparent;
            message2.TextColor = Color.Transparent;
            message2.BackgroundColor = Color.Transparent;
            message3.TextColor = Color.FromRgb(56, 115, 246);
            message3.BackgroundColor = Color.Transparent;
            await Task.Delay(250);

            Application.Current.Properties["SelectedIngredient1"] = txt_selectedrecipe.Text;
            Application.Current.Properties["SelectedIngredient2"] = txt_selectedrecipe1.Text;
            Application.Current.Properties["SelectedIngredient3"] = txt_selectedrecipe2.Text;

            await Navigation.PushAsync(new RecipeOutputPage());
        }
    }
}