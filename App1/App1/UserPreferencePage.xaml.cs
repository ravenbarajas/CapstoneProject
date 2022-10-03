using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class UserPreferencePage : ContentPage
    {
        public UserPreferencePage()
        {
            InitializeComponent();
        }

        private void Type1_Clicked(object sender, EventArgs e)
        {
            Type1.BackgroundColor = Color.SkyBlue;
            Type2.BackgroundColor = Color.LightGray;
            Type3.BackgroundColor = Color.LightGray;
        }

        private void Type2_Clicked(object sender, EventArgs e)
        {
            Type1.BackgroundColor = Color.LightGray;
            Type2.BackgroundColor = Color.SkyBlue;
            Type3.BackgroundColor = Color.LightGray;
        }

        private void Type3_Clicked(object sender, EventArgs e)
        {
            Type1.BackgroundColor = Color.LightGray;
            Type2.BackgroundColor = Color.LightGray;
            Type3.BackgroundColor = Color.SkyBlue;
        }

        private void Course1_Clicked(object sender, EventArgs e)
        {
            Course1.BackgroundColor = Color.SkyBlue;
            Course2.BackgroundColor = Color.LightGray;
            Course3.BackgroundColor = Color.LightGray;
            Course4.BackgroundColor = Color.LightGray;
        }

        private void Course2_Clicked(object sender, EventArgs e)
        {
            Course1.BackgroundColor = Color.LightGray;
            Course2.BackgroundColor = Color.SkyBlue;
            Course3.BackgroundColor = Color.LightGray;
            Course4.BackgroundColor = Color.LightGray;
        }

        private void Course3_Clicked(object sender, EventArgs e)
        {
            Course1.BackgroundColor = Color.LightGray;
            Course2.BackgroundColor = Color.LightGray;
            Course3.BackgroundColor = Color.SkyBlue;
            Course4.BackgroundColor = Color.LightGray;
        }

        private void Course4_Clicked(object sender, EventArgs e)
        {
            Course1.BackgroundColor = Color.LightGray;
            Course2.BackgroundColor = Color.LightGray;
            Course3.BackgroundColor = Color.LightGray;
            Course4.BackgroundColor = Color.SkyBlue;
        }

        private void Difficulty1_Clicked(object sender, EventArgs e)
        {
            Difficulty1.BackgroundColor = Color.SkyBlue;
            Difficulty2.BackgroundColor = Color.LightGray;
            Difficulty3.BackgroundColor = Color.LightGray;
            Difficulty4.BackgroundColor = Color.LightGray;
        }

        private void Difficulty2_Clicked(object sender, EventArgs e)
        {
            Difficulty1.BackgroundColor = Color.LightGray;
            Difficulty2.BackgroundColor = Color.SkyBlue;
            Difficulty3.BackgroundColor = Color.LightGray;
            Difficulty4.BackgroundColor = Color.LightGray;
        }

        private void Difficulty3_Clicked(object sender, EventArgs e)
        {
            Difficulty1.BackgroundColor = Color.LightGray;
            Difficulty2.BackgroundColor = Color.LightGray;
            Difficulty3.BackgroundColor = Color.SkyBlue;
            Difficulty4.BackgroundColor = Color.LightGray;
        }

        private void Difficulty4_Clicked(object sender, EventArgs e)
        {
            Difficulty1.BackgroundColor = Color.LightGray;
            Difficulty2.BackgroundColor = Color.LightGray;
            Difficulty3.BackgroundColor = Color.LightGray;
            Difficulty4.BackgroundColor = Color.SkyBlue;
        }

        private void Servings1_Clicked(object sender, EventArgs e)
        {
            Servings1.BackgroundColor = Color.SkyBlue;
            Servings2.BackgroundColor = Color.LightGray;
            Servings3.BackgroundColor = Color.LightGray;
            Servings4.BackgroundColor = Color.LightGray;
        }

        private void Servings2_Clicked(object sender, EventArgs e)
        {
            Servings1.BackgroundColor = Color.LightGray;
            Servings2.BackgroundColor = Color.SkyBlue;
            Servings3.BackgroundColor = Color.LightGray;
            Servings4.BackgroundColor = Color.LightGray;
        }

        private void Servings3_Clicked(object sender, EventArgs e)
        {
            Servings1.BackgroundColor = Color.LightGray;
            Servings2.BackgroundColor = Color.LightGray;
            Servings3.BackgroundColor = Color.SkyBlue;
            Servings4.BackgroundColor = Color.LightGray;
        }

        private void Servings4_Clicked(object sender, EventArgs e)
        {
            Servings1.BackgroundColor = Color.LightGray;
            Servings2.BackgroundColor = Color.LightGray;
            Servings3.BackgroundColor = Color.LightGray;
            Servings4.BackgroundColor = Color.SkyBlue;
        }

        async void Confirm1_Clicked(object sender, EventArgs e)
        {
            bool Answer = await DisplayAlert("Confirm Selection?", "You will not be able to edit after", "Yes", "No");
            if (Answer == true)
            {
                /*DITO YUNG STATEMENT NUNG NEXT PAGE */
            }
        }
    }
}