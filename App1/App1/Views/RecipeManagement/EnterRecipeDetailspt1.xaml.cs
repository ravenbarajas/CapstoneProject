using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.RecipeManagement
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnterRecipeDetailspt1 : ContentPage
    {
        public EnterRecipeDetailspt1()
        {
            InitializeComponent();
        }
        private async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EnterRecipeDetailspt2());
        }

        //private void pickerhide1_Clicked(object sender, EventArgs e)
        //{
        //    picker1show();
        //    var btn = (Button)sender;
        //    pk_diettype.IsVisible = false;
        //    pk_lifestyle.IsVisible = false;
        //    pk_homecook.IsVisible = false;
        //    pk_frequency.IsVisible = false;
        //    pk_cooktime.IsVisible = false;
        //    pk_cookskill.IsVisible = false;

        //    lbl10.IsVisible = false;
        //    lbl11.IsVisible = false;

        //    lbl20.IsVisible = false;
        //    lbl21.IsVisible = false;

        //    lbl30.IsVisible = false;
        //    lbl31.IsVisible = false;

        //    lbl40.IsVisible = false;
        //    lbl41.IsVisible = false;

        //    lbl50.IsVisible = false;
        //    lbl51.IsVisible = false;

        //    lbl60.IsVisible = false;
        //    lbl61.IsVisible = false;

        //    hide1.BackgroundColor = Color.FromRgb(63, 157, 47);
        //    hide1.TextColor = Color.FromRgb(255, 255, 255);

        //    hide2.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide2.TextColor = Color.FromRgb(0, 0, 0);

        //    hide3.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide3.TextColor = Color.FromRgb(0, 0, 0);

        //    hide4.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide4.TextColor = Color.FromRgb(0, 0, 0);

        //    hide5.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide5.TextColor = Color.FromRgb(0, 0, 0);

        //    hide6.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide6.TextColor = Color.FromRgb(0, 0, 0);

        //    hide7.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide7.TextColor = Color.FromRgb(0, 0, 0);
        //}
        //private void pickerhide2_Clicked(object sender, EventArgs e)
        //{
        //    picker2show();
        //    var btn = (Button)sender;
        //    pk_allergies.IsVisible = false;
        //    pk_lifestyle.IsVisible = false;
        //    pk_homecook.IsVisible = false;
        //    pk_frequency.IsVisible = false;
        //    pk_cooktime.IsVisible = false;
        //    pk_cookskill.IsVisible = false;

        //    lbl00.IsVisible = false;
        //    lbl01.IsVisible = false;

        //    lbl20.IsVisible = false;
        //    lbl21.IsVisible = false;

        //    lbl30.IsVisible = false;
        //    lbl31.IsVisible = false;

        //    lbl40.IsVisible = false;
        //    lbl41.IsVisible = false;

        //    lbl50.IsVisible = false;
        //    lbl51.IsVisible = false;

        //    lbl60.IsVisible = false;
        //    lbl61.IsVisible = false;

        //    hide1.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide1.TextColor = Color.FromRgb(0, 0, 0);

        //    hide2.BackgroundColor = Color.FromRgb(63, 157, 47);
        //    hide2.TextColor = Color.FromRgb(255, 255, 255);

        //    hide3.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide3.TextColor = Color.FromRgb(0, 0, 0);

        //    hide4.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide4.TextColor = Color.FromRgb(0, 0, 0);

        //    hide5.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide5.TextColor = Color.FromRgb(0, 0, 0);

        //    hide6.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide6.TextColor = Color.FromRgb(0, 0, 0);

        //    hide7.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide7.TextColor = Color.FromRgb(0, 0, 0);
        //}
        //private void pickerhide3_Clicked(object sender, EventArgs e)
        //{
        //    picker3show();
        //    var btn = (Button)sender;
        //    pk_allergies.IsVisible = false;
        //    pk_diettype.IsVisible = false;
        //    pk_homecook.IsVisible = false;
        //    pk_frequency.IsVisible = false;
        //    pk_cooktime.IsVisible = false;
        //    pk_cookskill.IsVisible = false;

        //    lbl00.IsVisible = false;
        //    lbl01.IsVisible = false;

        //    lbl10.IsVisible = false;
        //    lbl11.IsVisible = false;

        //    lbl30.IsVisible = false;
        //    lbl31.IsVisible = false;

        //    lbl40.IsVisible = false;
        //    lbl41.IsVisible = false;

        //    lbl50.IsVisible = false;
        //    lbl51.IsVisible = false;

        //    lbl60.IsVisible = false;
        //    lbl61.IsVisible = false;

        //    hide1.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide1.TextColor = Color.FromRgb(0, 0, 0);

        //    hide2.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide2.TextColor = Color.FromRgb(0, 0, 0);

        //    hide3.BackgroundColor = Color.FromRgb(63, 157, 47);
        //    hide3.TextColor = Color.FromRgb(255, 255, 255);

        //    hide4.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide4.TextColor = Color.FromRgb(0, 0, 0);

        //    hide5.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide5.TextColor = Color.FromRgb(0, 0, 0);

        //    hide6.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide6.TextColor = Color.FromRgb(0, 0, 0);

        //    hide7.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide7.TextColor = Color.FromRgb(0, 0, 0);
        //}
        //private void pickerhide4_Clicked(object sender, EventArgs e)
        //{
        //    picker4show();
        //    var btn = (Button)sender;
        //    pk_allergies.IsVisible = false;
        //    pk_diettype.IsVisible = false;
        //    pk_lifestyle.IsVisible = false;
        //    pk_frequency.IsVisible = false;
        //    pk_cooktime.IsVisible = false;
        //    pk_cookskill.IsVisible = false;

        //    lbl00.IsVisible = false;
        //    lbl01.IsVisible = false;

        //    lbl10.IsVisible = false;
        //    lbl11.IsVisible = false;

        //    lbl20.IsVisible = false;
        //    lbl21.IsVisible = false;

        //    lbl40.IsVisible = false;
        //    lbl41.IsVisible = false;

        //    lbl50.IsVisible = false;
        //    lbl51.IsVisible = false;

        //    lbl60.IsVisible = false;
        //    lbl61.IsVisible = false;

        //    hide1.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide1.TextColor = Color.FromRgb(0, 0, 0);

        //    hide2.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide2.TextColor = Color.FromRgb(0, 0, 0);

        //    hide3.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide3.TextColor = Color.FromRgb(0, 0, 0);

        //    hide4.BackgroundColor = Color.FromRgb(63, 157, 47);
        //    hide4.TextColor = Color.FromRgb(255, 255, 255);

        //    hide5.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide5.TextColor = Color.FromRgb(0, 0, 0);

        //    hide6.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide6.TextColor = Color.FromRgb(0, 0, 0);

        //    hide7.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide7.TextColor = Color.FromRgb(0, 0, 0);
        //}
        //private void pickerhide5_Clicked(object sender, EventArgs e)
        //{
        //    picker5show();
        //    var btn = (Button)sender;
        //    pk_allergies.IsVisible = false;
        //    pk_diettype.IsVisible = false;
        //    pk_lifestyle.IsVisible = false;
        //    pk_homecook.IsVisible = false;
        //    pk_cooktime.IsVisible = false;
        //    pk_cookskill.IsVisible = false;

        //    lbl00.IsVisible = false;
        //    lbl01.IsVisible = false;

        //    lbl10.IsVisible = false;
        //    lbl11.IsVisible = false;

        //    lbl20.IsVisible = false;
        //    lbl21.IsVisible = false;

        //    lbl30.IsVisible = false;
        //    lbl31.IsVisible = false;

        //    lbl50.IsVisible = false;
        //    lbl51.IsVisible = false;

        //    lbl60.IsVisible = false;
        //    lbl61.IsVisible = false;

        //    hide1.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide1.TextColor = Color.FromRgb(0, 0, 0);

        //    hide2.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide2.TextColor = Color.FromRgb(0, 0, 0);

        //    hide3.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide3.TextColor = Color.FromRgb(0, 0, 0);

        //    hide4.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide4.TextColor = Color.FromRgb(0, 0, 0);

        //    hide5.BackgroundColor = Color.FromRgb(63, 157, 47);
        //    hide5.TextColor = Color.FromRgb(255, 255, 255);

        //    hide6.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide6.TextColor = Color.FromRgb(0, 0, 0);

        //    hide7.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide7.TextColor = Color.FromRgb(0, 0, 0);
        //}
        //private void pickerhide6_Clicked(object sender, EventArgs e)
        //{
        //    picker6show();
        //    var btn = (Button)sender;
        //    pk_allergies.IsVisible = false;
        //    pk_diettype.IsVisible = false;
        //    pk_lifestyle.IsVisible = false;
        //    pk_frequency.IsVisible = false;
        //    pk_cookskill.IsVisible = false;

        //    lbl00.IsVisible = false;
        //    lbl01.IsVisible = false;

        //    lbl10.IsVisible = false;
        //    lbl11.IsVisible = false;

        //    lbl20.IsVisible = false;
        //    lbl21.IsVisible = false;

        //    lbl30.IsVisible = false;
        //    lbl31.IsVisible = false;

        //    lbl40.IsVisible = false;
        //    lbl41.IsVisible = false;

        //    lbl60.IsVisible = false;
        //    lbl61.IsVisible = false;

        //    hide1.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide1.TextColor = Color.FromRgb(0, 0, 0);

        //    hide2.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide2.TextColor = Color.FromRgb(0, 0, 0);

        //    hide3.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide3.TextColor = Color.FromRgb(0, 0, 0);

        //    hide4.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide4.TextColor = Color.FromRgb(0, 0, 0);

        //    hide5.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide5.TextColor = Color.FromRgb(0, 0, 0);

        //    hide6.BackgroundColor = Color.FromRgb(63, 157, 47);
        //    hide6.TextColor = Color.FromRgb(255, 255, 255);

        //    hide7.BackgroundColor = Color.FromRgb(214, 215, 215);
        //    hide7.TextColor = Color.FromRgb(0, 0, 0);
        //}
    }
}