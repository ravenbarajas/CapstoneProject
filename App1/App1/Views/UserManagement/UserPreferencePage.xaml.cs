using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.UserManagement
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPreferencePage : ContentPage
    {
        public UserPreferencePage()
        {
            InitializeComponent();
            txt_name.Text = $"{Application.Current.Properties["username"].ToString()}";

            List<Recipes> ActiveLifestyle = new List<Recipes>
            {
                new Recipes{RecipeName="", TotalTime="", RecipeCategory="", Keywords="", CalorieContent="", SugarContent="", SodiumContent="", CholesterolContent="", ImageUrl=""}
            };
            List<Recipes> SedentaryLifestyle = new List<Recipes>
            {
                new Recipes{RecipeName="", TotalTime="", RecipeCategory="", Keywords="", CalorieContent="", SugarContent="", SodiumContent="", CholesterolContent="", ImageUrl=""}
            };
            List<Recipes> AverageLifestyle = new List<Recipes>
            {
                new Recipes{RecipeName="", TotalTime="", RecipeCategory="", Keywords="", CalorieContent="", SugarContent="", SodiumContent="", CholesterolContent="", ImageUrl=""}
            };
        }
        private async void Finish_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Confirmation", "Confirm answers?", "Confirm", "Not yet");
            if (response == true)
            {
                Application.Current.Properties["username"] = txt_name.Text;
                await Navigation.PushAsync(new WelcomePage());
            }
            else
            {

            }
        }
        private void activities1_Clicked(object sender, EventArgs e)
        {
            AC00.BackgroundColor = Color.FromRgb(63, 157, 47);
            AC01.BackgroundColor = Color.FromRgb(70, 127, 215);
            AC02.BackgroundColor = Color.FromRgb(70, 127, 215);
            AC03.BackgroundColor = Color.FromRgb(70, 127, 215);
            AC04.BackgroundColor = Color.FromRgb(70, 127, 215);
        }
        private void activities2_Clicked(object sender, EventArgs e)
        {
            AC00.BackgroundColor = Color.FromRgb(70, 127, 215);
            AC01.BackgroundColor = Color.FromRgb(63, 157, 47);
            AC02.BackgroundColor = Color.FromRgb(70, 127, 215);
            AC03.BackgroundColor = Color.FromRgb(70, 127, 215);
            AC04.BackgroundColor = Color.FromRgb(70, 127, 215);
        }
        private void activities3_Clicked(object sender, EventArgs e)
        {
            AC00.BackgroundColor = Color.FromRgb(70, 127, 215);
            AC01.BackgroundColor = Color.FromRgb(70, 127, 215);
            AC02.BackgroundColor = Color.FromRgb(63, 157, 47);
            AC03.BackgroundColor = Color.FromRgb(70, 127, 215);
            AC04.BackgroundColor = Color.FromRgb(70, 127, 215);
        }
        private void activities4_Clicked(object sender, EventArgs e)
        {
            AC00.BackgroundColor = Color.FromRgb(70, 127, 215);
            AC01.BackgroundColor = Color.FromRgb(70, 127, 215);
            AC02.BackgroundColor = Color.FromRgb(70, 127, 215);
            AC03.BackgroundColor = Color.FromRgb(63, 157, 47);
            AC04.BackgroundColor = Color.FromRgb(70, 127, 215);
        }
        private void activities5_Clicked(object sender, EventArgs e)
        {
            AC00.BackgroundColor = Color.FromRgb(70, 127, 215);
            AC01.BackgroundColor = Color.FromRgb(70, 127, 215);
            AC02.BackgroundColor = Color.FromRgb(70, 127, 215);
            AC03.BackgroundColor = Color.FromRgb(70, 127, 215);
            AC04.BackgroundColor = Color.FromRgb(63, 157, 47);
        }

        private void foodtype1_Clicked(object sender, EventArgs e)
        {
            FT00.BackgroundColor = Color.FromRgb(63, 157, 47);
            FT01.BackgroundColor = Color.FromRgb(70, 127, 215);
            FT02.BackgroundColor = Color.FromRgb(70, 127, 215);
            FT03.BackgroundColor = Color.FromRgb(70, 127, 215);
            FT04.BackgroundColor = Color.FromRgb(70, 127, 215);
        }
        private void foodtype2_Clicked(object sender, EventArgs e)
        {
            FT00.BackgroundColor = Color.FromRgb(70, 127, 215);
            FT01.BackgroundColor = Color.FromRgb(63, 157, 47);
            FT02.BackgroundColor = Color.FromRgb(70, 127, 215);
            FT03.BackgroundColor = Color.FromRgb(70, 127, 215);
            FT04.BackgroundColor = Color.FromRgb(70, 127, 215);
        }
        private void foodtype3_Clicked(object sender, EventArgs e)
        {
            FT00.BackgroundColor = Color.FromRgb(70, 127, 215);
            FT01.BackgroundColor = Color.FromRgb(70, 127, 215);
            FT02.BackgroundColor = Color.FromRgb(63, 157, 47);
            FT03.BackgroundColor = Color.FromRgb(70, 127, 215);
            FT04.BackgroundColor = Color.FromRgb(70, 127, 215);
        }
        private void foodtype4_Clicked(object sender, EventArgs e)
        {
            FT00.BackgroundColor = Color.FromRgb(70, 127, 215);
            FT01.BackgroundColor = Color.FromRgb(70, 127, 215);
            FT02.BackgroundColor = Color.FromRgb(70, 127, 215);
            FT03.BackgroundColor = Color.FromRgb(63, 157, 47);
            FT04.BackgroundColor = Color.FromRgb(70, 127, 215);
        }
        private void foodtype5_Clicked(object sender, EventArgs e)
        {
            FT00.BackgroundColor = Color.FromRgb(70, 127, 215);
            FT01.BackgroundColor = Color.FromRgb(70, 127, 215);
            FT02.BackgroundColor = Color.FromRgb(70, 127, 215);
            FT03.BackgroundColor = Color.FromRgb(70, 127, 215);
            FT04.BackgroundColor = Color.FromRgb(63, 157, 47);
        }

        private void foodprep1_Clicked(object sender, EventArgs e)
        {
            FP00.BackgroundColor = Color.FromRgb(63, 157, 47);
            FP01.BackgroundColor = Color.FromRgb(70, 127, 215);
            FP02.BackgroundColor = Color.FromRgb(70, 127, 215);
            FP03.BackgroundColor = Color.FromRgb(70, 127, 215);
        }
        private void foodprep2_Clicked(object sender, EventArgs e)
        {
            FP00.BackgroundColor = Color.FromRgb(70, 127, 215);
            FP01.BackgroundColor = Color.FromRgb(63, 157, 47);
            FP02.BackgroundColor = Color.FromRgb(70, 127, 215);
            FP03.BackgroundColor = Color.FromRgb(70, 127, 215);
        }
        private void foodprep3_Clicked(object sender, EventArgs e)
        {
            FP00.BackgroundColor = Color.FromRgb(70, 127, 215);
            FP01.BackgroundColor = Color.FromRgb(70, 127, 215);
            FP02.BackgroundColor = Color.FromRgb(63, 157, 47);
            FP03.BackgroundColor = Color.FromRgb(70, 127, 215);
        }
        private void foodprep4_Clicked(object sender, EventArgs e)
        {
            FP00.BackgroundColor = Color.FromRgb(70, 127, 215);
            FP01.BackgroundColor = Color.FromRgb(70, 127, 215);
            FP02.BackgroundColor = Color.FromRgb(70, 127, 215);
            FP03.BackgroundColor = Color.FromRgb(63, 157, 47);
        }
    }
}