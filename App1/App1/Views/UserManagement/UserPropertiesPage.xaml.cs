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
    public partial class UserPropertiesPage : ContentPage
    {
        public UserPropertiesPage()
        {
            InitializeComponent();

            var allergies = new List<string>();
            allergies.Add("None");
            allergies.Add("Nuts");
            allergies.Add("Seafood");
            allergies.Add("Dairy");
            allergies.Add("Poultry");

            pk_allergies.ItemsSource = allergies;
            lbl_allergies.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_allergies));

            var diettype = new List<string>();
            diettype.Add("Normal Diet");
            diettype.Add("High Calorie");
            diettype.Add("Low Sugar");
            diettype.Add("Low Sodium");
            diettype.Add("Low Fat");
            
            pk_diettype.ItemsSource = diettype;
            lbl_diettype.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_diettype));

            var lifestyle = new List<string>();
            lifestyle.Add("Active(4 - 5 days a week)");
            lifestyle.Add("Average(2 - 3 days a week)");
            lifestyle.Add("Sedentary(0 - 1 day a week)");

            pk_lifestyle.ItemsSource = lifestyle;
            lbl_lifestyle.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_lifestyle));

            var homecook = new List<string>();
            homecook.Add("Myself");
            homecook.Add("Older Brother / Sister");
            homecook.Add("Older Parent / Guardian");

            pk_homecook.ItemsSource = homecook;
            lbl_homecook.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_homecook));

            var frequency = new List<string>();
            frequency.Add("Everyday");
            frequency.Add("1x - 3x a week");
            frequency.Add("4x - 6x a week");

            pk_frequency.ItemsSource = frequency;
            lbl_frequency.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_frequency));

            var cooktime = new List<string>();
            cooktime.Add("0 - 30 mins");
            cooktime.Add("30 - 60 mins");
            cooktime.Add("60 - 120 mins");

            pk_cooktime.ItemsSource = cooktime;
            lbl_cooktime.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_cooktime));

            var cookskill = new List<string>();
            cookskill.Add("1 - 3(Beginner)");
            cookskill.Add("4 - 5(Average)");
            cookskill.Add("6 - 8(Home Cook)");
            cookskill.Add("8 - 10(Experienced)");

            pk_cookskill.ItemsSource = cookskill;
            lbl_cookskill.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_cookskill));

            pk_diettype.IsVisible = false;
            pk_lifestyle.IsVisible = false;
            pk_homecook.IsVisible = false;
            pk_frequency.IsVisible = false;
            pk_cooktime.IsVisible = false;
            pk_cookskill.IsVisible = false;

            lbl10.IsVisible = false;
            lbl11.IsVisible = false;

            lbl20.IsVisible = false;
            lbl21.IsVisible = false;

            lbl30.IsVisible = false;
            lbl31.IsVisible = false;

            lbl40.IsVisible = false;
            lbl41.IsVisible = false;

            lbl50.IsVisible = false;
            lbl51.IsVisible = false;

            lbl60.IsVisible = false;
            lbl61.IsVisible = false;

            lbl_allergies.IsVisible = false;
            lbl_diettype.IsVisible = false;
            lbl_lifestyle.IsVisible = false;
            lbl_homecook.IsVisible = false;
            lbl_frequency.IsVisible = false;
            lbl_cooktime.IsVisible = false;
            lbl_cookskill.IsVisible = false;
        }
        private async void UserPropertiesDone_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserPreferencePage());
            Application.Current.Properties["username"] = txt_username.Text;
        }
        private async void PreviousButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserInfoPage());
        }
        private void picker1show()
        {
            lbl00.IsVisible = true;
            lbl01.IsVisible = true;
            pk_allergies.IsVisible = true;
        }
        private void picker2show()
        {
            lbl10.IsVisible = true;
            lbl11.IsVisible = true;
            pk_diettype.IsVisible = true;
        }
        private void picker3show()
        {
            lbl20.IsVisible = true;
            lbl21.IsVisible = true;
            pk_lifestyle.IsVisible = true;
        }
        private void picker4show()
        {
            lbl30.IsVisible = true;
            lbl31.IsVisible = true;
            pk_homecook.IsVisible = true;
        }
        private void picker5show()
        {
            lbl40.IsVisible = true;
            lbl41.IsVisible = true;
            pk_frequency.IsVisible = true;
        }
        private void picker6show()
        {
            lbl50.IsVisible = true;
            lbl51.IsVisible = true;
            pk_cooktime.IsVisible = true;
        }
        private void picker7show()
        {
            lbl60.IsVisible = true;
            lbl61.IsVisible = true;
            pk_cookskill.IsVisible = true;
        }

        private void pickerhide1_Clicked(object sender, EventArgs e)
        {
            picker1show();
            var btn = (Button)sender;
            pk_diettype.IsVisible = false;
            pk_lifestyle.IsVisible = false;
            pk_homecook.IsVisible = false;
            pk_frequency.IsVisible = false;
            pk_cooktime.IsVisible = false;
            pk_cookskill.IsVisible = false;

            lbl10.IsVisible = false;
            lbl11.IsVisible = false;

            lbl20.IsVisible = false;
            lbl21.IsVisible = false;

            lbl30.IsVisible = false;
            lbl31.IsVisible = false;

            lbl40.IsVisible = false;
            lbl41.IsVisible = false;

            lbl50.IsVisible = false;
            lbl51.IsVisible = false;

            lbl60.IsVisible = false;
            lbl61.IsVisible = false;

            hide1.BackgroundColor = Color.FromRgb(63, 157, 47);
            hide1.TextColor = Color.FromRgb(255, 255, 255);

            hide2.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide2.TextColor = Color.FromRgb(0, 0, 0);

            hide3.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide3.TextColor = Color.FromRgb(0, 0, 0);

            hide4.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide4.TextColor = Color.FromRgb(0, 0, 0);

            hide5.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide5.TextColor = Color.FromRgb(0, 0, 0);

            hide6.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide6.TextColor = Color.FromRgb(0, 0, 0);

            hide7.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide7.TextColor = Color.FromRgb(0, 0, 0);
        }
        private void pickerhide2_Clicked(object sender, EventArgs e)
        {
            picker2show();
            var btn = (Button)sender;
            pk_allergies.IsVisible = false;
            pk_lifestyle.IsVisible = false;
            pk_homecook.IsVisible = false;
            pk_frequency.IsVisible = false;
            pk_cooktime.IsVisible = false;
            pk_cookskill.IsVisible = false;

            lbl00.IsVisible = false;
            lbl01.IsVisible = false;

            lbl20.IsVisible = false;
            lbl21.IsVisible = false;

            lbl30.IsVisible = false;
            lbl31.IsVisible = false;

            lbl40.IsVisible = false;
            lbl41.IsVisible = false;

            lbl50.IsVisible = false;
            lbl51.IsVisible = false;

            lbl60.IsVisible = false;
            lbl61.IsVisible = false;

            hide1.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide1.TextColor = Color.FromRgb(0, 0, 0);

            hide2.BackgroundColor = Color.FromRgb(63, 157, 47);
            hide2.TextColor = Color.FromRgb(255, 255, 255);

            hide3.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide3.TextColor = Color.FromRgb(0, 0, 0);

            hide4.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide4.TextColor = Color.FromRgb(0, 0, 0);

            hide5.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide5.TextColor = Color.FromRgb(0, 0, 0);

            hide6.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide6.TextColor = Color.FromRgb(0, 0, 0);

            hide7.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide7.TextColor = Color.FromRgb(0, 0, 0);
        }
        private void pickerhide3_Clicked(object sender, EventArgs e)
        {
            picker3show();
            var btn = (Button)sender;
            pk_allergies.IsVisible = false;
            pk_diettype.IsVisible = false;
            pk_homecook.IsVisible = false;
            pk_frequency.IsVisible = false;
            pk_cooktime.IsVisible = false;
            pk_cookskill.IsVisible = false;

            lbl00.IsVisible = false;
            lbl01.IsVisible = false;

            lbl10.IsVisible = false;
            lbl11.IsVisible = false;

            lbl30.IsVisible = false;
            lbl31.IsVisible = false;

            lbl40.IsVisible = false;
            lbl41.IsVisible = false;

            lbl50.IsVisible = false;
            lbl51.IsVisible = false;

            lbl60.IsVisible = false;
            lbl61.IsVisible = false;

            hide1.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide1.TextColor = Color.FromRgb(0, 0, 0);

            hide2.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide2.TextColor = Color.FromRgb(0, 0, 0);

            hide3.BackgroundColor = Color.FromRgb(63, 157, 47);
            hide3.TextColor = Color.FromRgb(255, 255, 255);

            hide4.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide4.TextColor = Color.FromRgb(0, 0, 0);

            hide5.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide5.TextColor = Color.FromRgb(0, 0, 0);

            hide6.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide6.TextColor = Color.FromRgb(0, 0, 0);

            hide7.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide7.TextColor = Color.FromRgb(0, 0, 0);
        }
        private void pickerhide4_Clicked(object sender, EventArgs e)
        {
            picker4show();
            var btn = (Button)sender;
            pk_allergies.IsVisible = false;
            pk_diettype.IsVisible = false;
            pk_lifestyle.IsVisible = false;
            pk_frequency.IsVisible = false;
            pk_cooktime.IsVisible = false;
            pk_cookskill.IsVisible = false;

            lbl00.IsVisible = false;
            lbl01.IsVisible = false;

            lbl10.IsVisible = false;
            lbl11.IsVisible = false;

            lbl20.IsVisible = false;
            lbl21.IsVisible = false;

            lbl40.IsVisible = false;
            lbl41.IsVisible = false;

            lbl50.IsVisible = false;
            lbl51.IsVisible = false;

            lbl60.IsVisible = false;
            lbl61.IsVisible = false;

            hide1.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide1.TextColor = Color.FromRgb(0, 0, 0);

            hide2.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide2.TextColor = Color.FromRgb(0, 0, 0);

            hide3.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide3.TextColor = Color.FromRgb(0, 0, 0);

            hide4.BackgroundColor = Color.FromRgb(63, 157, 47);
            hide4.TextColor = Color.FromRgb(255, 255, 255);

            hide5.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide5.TextColor = Color.FromRgb(0, 0, 0);

            hide6.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide6.TextColor = Color.FromRgb(0, 0, 0);

            hide7.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide7.TextColor = Color.FromRgb(0, 0, 0);
        }
        private void pickerhide5_Clicked(object sender, EventArgs e)
        {
            picker5show();
            var btn = (Button)sender;
            pk_allergies.IsVisible = false;
            pk_diettype.IsVisible = false;
            pk_lifestyle.IsVisible = false;
            pk_homecook.IsVisible = false;
            pk_cooktime.IsVisible = false;
            pk_cookskill.IsVisible = false;

            lbl00.IsVisible = false;
            lbl01.IsVisible = false;

            lbl10.IsVisible = false;
            lbl11.IsVisible = false;

            lbl20.IsVisible = false;
            lbl21.IsVisible = false;

            lbl30.IsVisible = false;
            lbl31.IsVisible = false;

            lbl50.IsVisible = false;
            lbl51.IsVisible = false;

            lbl60.IsVisible = false;
            lbl61.IsVisible = false;

            hide1.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide1.TextColor = Color.FromRgb(0, 0, 0);

            hide2.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide2.TextColor = Color.FromRgb(0, 0, 0);

            hide3.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide3.TextColor = Color.FromRgb(0, 0, 0);

            hide4.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide4.TextColor = Color.FromRgb(0, 0, 0);

            hide5.BackgroundColor = Color.FromRgb(63, 157, 47);
            hide5.TextColor = Color.FromRgb(255, 255, 255);

            hide6.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide6.TextColor = Color.FromRgb(0, 0, 0);

            hide7.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide7.TextColor = Color.FromRgb(0, 0, 0);
        }
        private void pickerhide6_Clicked(object sender, EventArgs e)
        {
            picker6show();
            var btn = (Button)sender;
            pk_allergies.IsVisible = false;
            pk_diettype.IsVisible = false;
            pk_lifestyle.IsVisible = false;
            pk_frequency.IsVisible = false;
            pk_cookskill.IsVisible = false;

            lbl00.IsVisible = false;
            lbl01.IsVisible = false;

            lbl10.IsVisible = false;
            lbl11.IsVisible = false;

            lbl20.IsVisible = false;
            lbl21.IsVisible = false;

            lbl30.IsVisible = false;
            lbl31.IsVisible = false;

            lbl40.IsVisible = false;
            lbl41.IsVisible = false;

            lbl60.IsVisible = false;
            lbl61.IsVisible = false;

            hide1.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide1.TextColor = Color.FromRgb(0, 0, 0);

            hide2.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide2.TextColor = Color.FromRgb(0, 0, 0);

            hide3.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide3.TextColor = Color.FromRgb(0, 0, 0);

            hide4.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide4.TextColor = Color.FromRgb(0, 0, 0);

            hide5.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide5.TextColor = Color.FromRgb(0, 0, 0);

            hide6.BackgroundColor = Color.FromRgb(63, 157, 47);
            hide6.TextColor = Color.FromRgb(255, 255, 255);

            hide7.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide7.TextColor = Color.FromRgb(0, 0, 0);
        }
        private void pickerhide7_Clicked(object sender, EventArgs e)
        {
            picker7show();
            var btn = (Button)sender;
            pk_allergies.IsVisible = false;
            pk_diettype.IsVisible = false;
            pk_lifestyle.IsVisible = false;
            pk_frequency.IsVisible = false;
            pk_cooktime.IsVisible = false;

            lbl00.IsVisible = false;
            lbl01.IsVisible = false;

            lbl10.IsVisible = false;
            lbl11.IsVisible = false;

            lbl20.IsVisible = false;
            lbl21.IsVisible = false;

            lbl30.IsVisible = false;
            lbl31.IsVisible = false;

            lbl40.IsVisible = false;
            lbl41.IsVisible = false;

            lbl50.IsVisible = false;
            lbl51.IsVisible = false;

            hide1.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide1.TextColor = Color.FromRgb(0, 0, 0);

            hide2.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide2.TextColor = Color.FromRgb(0, 0, 0);

            hide3.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide3.TextColor = Color.FromRgb(0, 0, 0);

            hide4.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide4.TextColor = Color.FromRgb(0, 0, 0);

            hide5.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide5.TextColor = Color.FromRgb(0, 0, 0);

            hide6.BackgroundColor = Color.FromRgb(214, 215, 215);
            hide6.TextColor = Color.FromRgb(0, 0, 0);

            hide7.BackgroundColor = Color.FromRgb(63, 157, 47);
            hide7.TextColor = Color.FromRgb(255, 255, 255);
        }

        private void btnshow1(object sender, EventArgs e)
        {
            lbl_allergies.IsVisible = true;
        }
        private void btnshow2(object sender, EventArgs e)
        {
            lbl_diettype.IsVisible = true;
        }
        private void btnshow3(object sender, EventArgs e)
        {
            lbl_lifestyle.IsVisible = true;
        }
        private void btnshow4(object sender, EventArgs e)
        {
            lbl_homecook.IsVisible = true;
        }
        private void btnshow5(object sender, EventArgs e)
        {
            lbl_frequency.IsVisible = true;
        }
        private void btnshow6(object sender, EventArgs e)
        {
            lbl_cooktime.IsVisible = true;
        }
        private void btnshow7(object sender, EventArgs e)
        {
            lbl_cookskill.IsVisible = true;
        }
    }
}