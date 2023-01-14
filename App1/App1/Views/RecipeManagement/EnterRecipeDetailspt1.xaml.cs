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
        public static string recipeCookTime;
        public static string recipePrepTime;

        public EnterRecipeDetailspt1()
        {
            InitializeComponent();
        }
        private async void Next_Clicked(object sender, EventArgs e)
        {
            try
            {
                recipeCookTime = txt_cooktimehr.Text + "Hrs " + txt_cooktimemin.Text + "Mins";
                recipePrepTime = txt_preptimehr.Text + "Hrs " + txt_preptimemin.Text + "Mins";

                if (String.IsNullOrEmpty(recipeCookTime))
                {
                    await DisplayAlert("Warning", "Cook time is required", "Ok");
                    return;
                }
                if (String.IsNullOrEmpty(recipePrepTime))
                {
                    await DisplayAlert("Warning", "Prep time is required", "Ok");
                    return;
                }

                await Navigation.PushAsync(new EnterRecipeDetailspt2());
            }
            catch
            { 
            
            }
        }
        //private void SumHrTime()
        //{
        //    var hrval1 = int.Parse(txt_cooktimehr.Text);
        //    var hrval2 = int.Parse(txt_preptimehr.Text);

        //    // add them
        //    var hrsum = hrval1 + hrval2;
        //    lbl_totaltimehr.Text = hrsum.ToString();
        //}
        //private void SumMinTime()
        //{
        //    var minval1 = int.Parse(txt_cooktimemin.Text);
        //    var minval2 = int.Parse(txt_preptimemin.Text);

        //    // add them
        //    var minsum = minval1 + minval2;
        //    lbl_totaltimemin.Text = minsum.ToString();
        //}
        //private void txt_preptimemin_Unfocused(object sender, FocusEventArgs e)
        //{
        //    SumMinTime();
        //    SumHrTime();
        //    lbl_totaltimehrlabel.IsVisible = true;
        //    lbl_totaltimeminlabel.IsVisible = true;
        //}

        //private void picker1show()
        //{
        //    RK000.IsVisible = true;
        //    RK001.IsVisible = true;
        //    pk_RK002.IsVisible = true;
        //}
        //private void picker2show()
        //{
        //    RK100.IsVisible = true;
        //    RK101.IsVisible = true;
        //    pk_RK102.IsVisible = true;
        //}
        //private void picker3show()
        //{
        //    RK200.IsVisible = true;
        //    RK201.IsVisible = true;
        //    pk_RK202.IsVisible = true;
        //}
        //private void picker4show()
        //{
        //    RK300.IsVisible = true;
        //    RK301.IsVisible = true;
        //    pk_RK302.IsVisible = true;
        //}
        //private void picker5show()
        //{
        //    RK400.IsVisible = true;
        //    RK401.IsVisible = true;
        //    pk_RK402.IsVisible = true;
        //}
        //private void picker6show()
        //{
        //    RK500.IsVisible = true;
        //    RK501.IsVisible = true;
        //    pk_RK502.IsVisible = true;
        //}

        //private void pickerhide1_Clicked(object sender, EventArgs e)
        //{
        //    picker1show();
        //    var btn = (Button)sender;
        //    pk_RK102.IsVisible = false;
        //    pk_RK202.IsVisible = false;
        //    pk_RK302.IsVisible = false;
        //    pk_RK402.IsVisible = false;
        //    pk_RK502.IsVisible = false;

        //    RK100.IsVisible = false;
        //    RK101.IsVisible = false;

        //    RK200.IsVisible = false;
        //    RK201.IsVisible = false;

        //    RK300.IsVisible = false;
        //    RK301.IsVisible = false;

        //    RK400.IsVisible = false;
        //    RK401.IsVisible = false;

        //    RK500.IsVisible = false;
        //    RK501.IsVisible = false;

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
        //}
        //private void pickerhide2_Clicked(object sender, EventArgs e)
        //{
        //    picker2show();
        //    var btn = (Button)sender;
        //    pk_RK002.IsVisible = false;
        //    pk_RK202.IsVisible = false;
        //    pk_RK302.IsVisible = false;
        //    pk_RK402.IsVisible = false;
        //    pk_RK502.IsVisible = false;

        //    RK000.IsVisible = false;
        //    RK001.IsVisible = false;

        //    RK200.IsVisible = false;
        //    RK201.IsVisible = false;

        //    RK300.IsVisible = false;
        //    RK301.IsVisible = false;

        //    RK400.IsVisible = false;
        //    RK401.IsVisible = false;

        //    RK500.IsVisible = false;
        //    RK501.IsVisible = false;

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
        //}
        //private void pickerhide3_Clicked(object sender, EventArgs e)
        //{
        //    picker3show();
        //    var btn = (Button)sender;
        //    pk_RK002.IsVisible = false;
        //    pk_RK102.IsVisible = false;
        //    pk_RK302.IsVisible = false;
        //    pk_RK402.IsVisible = false;
        //    pk_RK502.IsVisible = false;

        //    RK000.IsVisible = false;
        //    RK001.IsVisible = false;

        //    RK100.IsVisible = false;
        //    RK101.IsVisible = false;

        //    RK300.IsVisible = false;
        //    RK301.IsVisible = false;

        //    RK400.IsVisible = false;
        //    RK401.IsVisible = false;

        //    RK500.IsVisible = false;
        //    RK501.IsVisible = false;

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
        //}
        //private void pickerhide4_Clicked(object sender, EventArgs e)
        //{
        //    picker4show();
        //    var btn = (Button)sender;
        //    pk_RK002.IsVisible = false;
        //    pk_RK102.IsVisible = false;
        //    pk_RK202.IsVisible = false;
        //    pk_RK402.IsVisible = false;
        //    pk_RK502.IsVisible = false;

        //    RK000.IsVisible = false;
        //    RK001.IsVisible = false;

        //    RK100.IsVisible = false;
        //    RK101.IsVisible = false;

        //    RK200.IsVisible = false;
        //    RK201.IsVisible = false;

        //    RK400.IsVisible = false;
        //    RK401.IsVisible = false;

        //    RK500.IsVisible = false;
        //    RK501.IsVisible = false;

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
        //}
        //private void pickerhide5_Clicked(object sender, EventArgs e)
        //{
        //    picker5show();
        //    var btn = (Button)sender;
        //    pk_RK002.IsVisible = false;
        //    pk_RK102.IsVisible = false;
        //    pk_RK202.IsVisible = false;
        //    pk_RK302.IsVisible = false;
        //    pk_RK502.IsVisible = false;

        //    RK000.IsVisible = false;
        //    RK001.IsVisible = false;

        //    RK100.IsVisible = false;
        //    RK101.IsVisible = false;

        //    RK200.IsVisible = false;
        //    RK201.IsVisible = false;

        //    RK300.IsVisible = false;
        //    RK301.IsVisible = false;

        //    RK500.IsVisible = false;
        //    RK501.IsVisible = false;

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
        //}
        //private void pickerhide6_Clicked(object sender, EventArgs e)
        //{
        //    picker6show();
        //    var btn = (Button)sender;
        //    pk_RK002.IsVisible = false;
        //    pk_RK102.IsVisible = false;
        //    pk_RK202.IsVisible = false;
        //    pk_RK302.IsVisible = false;
        //    pk_RK402.IsVisible = false;

        //    RK000.IsVisible = false;
        //    RK001.IsVisible = false;

        //    RK100.IsVisible = false;
        //    RK101.IsVisible = false;

        //    RK200.IsVisible = false;
        //    RK201.IsVisible = false;

        //    RK300.IsVisible = false;
        //    RK301.IsVisible = false;

        //    RK400.IsVisible = false;
        //    RK401.IsVisible = false;

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
        //}

        //private void btnshow1(object sender, EventArgs e)
        //{
        //    lbl_recipekeyword1.IsVisible = true;
        //}
        //private void btnshow2(object sender, EventArgs e)
        //{
        //    lbl_recipekeyword2.IsVisible = true;
        //}
        //private void btnshow3(object sender, EventArgs e)
        //{
        //    lbl_recipekeyword3.IsVisible = true;
        //}
        //private void btnshow4(object sender, EventArgs e)
        //{
        //    lbl_recipekeyword4.IsVisible = true;
        //}
        //private void btnshow5(object sender, EventArgs e)
        //{
        //    lbl_recipekeyword5.IsVisible = true;
        //}
        //private void btnshow6(object sender, EventArgs e)
        //{
        //    lbl_recipekeyword6.IsVisible = true;
        //}
    }
}