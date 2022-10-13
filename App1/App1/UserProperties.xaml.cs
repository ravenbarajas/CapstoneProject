using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserProperties : ContentPage
    {
        public UserProperties()
        {
            InitializeComponent();
        }
        private void AgeGroup_Clicked(object sender, EventArgs e)
        {
            AgeGroupOption1.BackgroundColor = Color.FromRgb(217, 217, 217);
            AgeGroupOption1.TextColor = Color.Black;
            AgeGroupOption1.BorderWidth = 1;
            AgeGroupOption1.BorderColor = Color.White;

            AgeGroupOption2.BackgroundColor = Color.FromRgb(217, 217, 217);
            AgeGroupOption2.TextColor = Color.Black;
            AgeGroupOption2.BorderWidth = 1;
            AgeGroupOption2.BorderColor = Color.White;

            AgeGroupOption3.BackgroundColor = Color.FromRgb(217, 217, 217);
            AgeGroupOption3.TextColor = Color.Black;
            AgeGroupOption3.BorderWidth = 1;
            AgeGroupOption3.BorderColor = Color.White;

            AgeGroupOption4.BackgroundColor = Color.FromRgb(217, 217, 217);
            AgeGroupOption4.TextColor = Color.Black;
            AgeGroupOption4.BorderWidth = 1;
            AgeGroupOption4.BorderColor = Color.White;

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(206, 147, 216);
            btn.TextColor = Color.White;
        }
        private void Lifestyle_Clicked(object sender, EventArgs e)
        {
            LifestyleOption1.BackgroundColor = Color.FromRgb(217, 217, 217);
            LifestyleOption1.TextColor = Color.Black;
            LifestyleOption1.BorderWidth = 1;
            LifestyleOption1.BorderColor = Color.White;

            LifestyleOption2.BackgroundColor = Color.FromRgb(217, 217, 217);
            LifestyleOption2.TextColor = Color.Black;
            LifestyleOption2.BorderWidth = 1;
            LifestyleOption2.BorderColor = Color.White;

            LifestyleOption3.BackgroundColor = Color.FromRgb(217, 217, 217);
            LifestyleOption3.TextColor = Color.Black;
            LifestyleOption3.BorderWidth = 1;
            LifestyleOption3.BorderColor = Color.White;

            LifestyleOption4.BackgroundColor = Color.FromRgb(217, 217, 217);
            LifestyleOption4.TextColor = Color.Black;
            LifestyleOption4.BorderWidth = 1;
            LifestyleOption4.BorderColor = Color.White;

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(206, 147, 216);
            btn.TextColor = Color.White;
        }
        private void HomeCook_Clicked(object sender, EventArgs e)
        {
            HomeCookOption1.BackgroundColor = Color.FromRgb(217, 217, 217);
            HomeCookOption1.TextColor = Color.Black;
            HomeCookOption1.BorderWidth = 1;
            HomeCookOption1.BorderColor = Color.White;

            HomeCookOption2.BackgroundColor = Color.FromRgb(217, 217, 217);
            HomeCookOption2.TextColor = Color.Black;
            HomeCookOption2.BorderWidth = 1;
            HomeCookOption2.BorderColor = Color.White;

            HomeCookOption3.BackgroundColor = Color.FromRgb(217, 217, 217);
            HomeCookOption3.TextColor = Color.Black;
            HomeCookOption3.BorderWidth = 1;
            HomeCookOption3.BorderColor = Color.White;

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(206, 147, 216);
            btn.TextColor = Color.White;
        }
        private void Frequency_Clicked(object sender, EventArgs e)
        {
            FrequencyOption1.BackgroundColor = Color.FromRgb(217, 217, 217);
            FrequencyOption1.TextColor = Color.Black;
            FrequencyOption1.BorderWidth = 1;
            FrequencyOption1.BorderColor = Color.White;

            FrequencyOption2.BackgroundColor = Color.FromRgb(217, 217, 217);
            FrequencyOption2.TextColor = Color.Black;
            FrequencyOption2.BorderWidth = 1;
            FrequencyOption2.BorderColor = Color.White;

            FrequencyOption3.BackgroundColor = Color.FromRgb(217, 217, 217);
            FrequencyOption3.TextColor = Color.Black;
            FrequencyOption3.BorderWidth = 1;
            FrequencyOption3.BorderColor = Color.White;

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(206, 147, 216);
            btn.TextColor = Color.White;
        }
        private void Time_Clicked(object sender, EventArgs e)
        {
            TimeOption1.BackgroundColor = Color.FromRgb(217, 217, 217);
            TimeOption1.TextColor = Color.Black;
            TimeOption1.BorderWidth = 1;
            TimeOption1.BorderColor = Color.White;

            TimeOption2.BackgroundColor = Color.FromRgb(217, 217, 217);
            TimeOption2.TextColor = Color.Black;
            TimeOption2.BorderWidth = 1;
            TimeOption2.BorderColor = Color.White;

            TimeOption3.BackgroundColor = Color.FromRgb(217, 217, 217);
            TimeOption3.TextColor = Color.Black;
            TimeOption3.BorderWidth = 1;
            TimeOption3.BorderColor = Color.White;

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(206, 147, 216);
            btn.TextColor = Color.White;
        }
        private void Skill_Clicked(object sender, EventArgs e)
        {
            SkillOption1.BackgroundColor = Color.FromRgb(217, 217, 217);
            SkillOption1.TextColor = Color.Black;
            SkillOption1.BorderWidth = 1;
            SkillOption1.BorderColor = Color.White;

            SkillOption2.BackgroundColor = Color.FromRgb(217, 217, 217);
            SkillOption2.TextColor = Color.Black;
            SkillOption2.BorderWidth = 1;
            SkillOption2.BorderColor = Color.White;

            SkillOption3.BackgroundColor = Color.FromRgb(217, 217, 217);
            SkillOption3.TextColor = Color.Black;
            SkillOption3.BorderWidth = 1;
            SkillOption3.BorderColor = Color.White;

            SkillOption4.BackgroundColor = Color.FromRgb(217, 217, 217);
            SkillOption4.TextColor = Color.Black;
            SkillOption4.BorderWidth = 1;
            SkillOption4.BorderColor = Color.White;

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(206, 147, 216);
            btn.TextColor = Color.White;
        }
        private void DietType_Clicked(object sender, EventArgs e)
        {
            DietTypeOption1.BackgroundColor = Color.FromRgb(217, 217, 217);
            DietTypeOption1.TextColor = Color.Black;
            DietTypeOption1.BorderWidth = 1;
            DietTypeOption1.BorderColor = Color.White;

            DietTypeOption2.BackgroundColor = Color.FromRgb(217, 217, 217);
            DietTypeOption2.TextColor = Color.Black;
            DietTypeOption2.BorderWidth = 1;
            DietTypeOption2.BorderColor = Color.White;

            DietTypeOption3.BackgroundColor = Color.FromRgb(217, 217, 217);
            DietTypeOption3.TextColor = Color.Black;
            DietTypeOption3.BorderWidth = 1;
            DietTypeOption3.BorderColor = Color.White;

            DietTypeOption4.BackgroundColor = Color.FromRgb(217, 217, 217);
            DietTypeOption4.TextColor = Color.Black;
            DietTypeOption4.BorderWidth = 1;
            DietTypeOption4.BorderColor = Color.White;

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(206, 147, 216);
            btn.TextColor = Color.White;
        }
        private void FoodAllergy_Clicked(object sender, EventArgs e)
        {
            FoodAllergyOption1.BackgroundColor = Color.FromRgb(217, 217, 217);
            FoodAllergyOption1.TextColor = Color.Black;
            FoodAllergyOption1.BorderWidth = 1;
            FoodAllergyOption1.BorderColor = Color.White;

            FoodAllergyOption2.BackgroundColor = Color.FromRgb(217, 217, 217);
            FoodAllergyOption2.TextColor = Color.Black;
            FoodAllergyOption2.BorderWidth = 1;
            FoodAllergyOption2.BorderColor = Color.White;

            FoodAllergyOption3.BackgroundColor = Color.FromRgb(217, 217, 217);
            FoodAllergyOption3.TextColor = Color.Black;
            FoodAllergyOption3.BorderWidth = 1;
            FoodAllergyOption3.BorderColor = Color.White;

            FoodAllergyOption4.BackgroundColor = Color.FromRgb(217, 217, 217);
            FoodAllergyOption4.TextColor = Color.Black;
            FoodAllergyOption4.BorderWidth = 1;
            FoodAllergyOption4.BorderColor = Color.White;

            var btn = (Button)sender;
            btn.BackgroundColor = Color.FromRgb(206, 147, 216);
            btn.TextColor = Color.White;
        }
        private async void UserPropertiesDone_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WelcomePage());
        }
    }
}