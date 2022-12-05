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
        userInfo repository = new userInfo();

        public static string userID;
        public static string email;
        public static string username;
        public static string lastname;
        public static string firstname;
        public static string birthdate;
        public static string age;

        public UserPreferencePage()
        {
            InitializeComponent();
            txt_name.Text = username;

            var activities = new List<string>();
            activities.Add("Reading");
            activities.Add("Cycling");
            activities.Add("Gym");
            activities.Add("Yoga");
            activities.Add("Gaming");

            pk_activities.ItemsSource = activities;
            lbl_activities.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_activities));

            var foodcategory1 = new List<string>();
            foodcategory1.Add("Mexican");
            foodcategory1.Add("Japanese");
            foodcategory1.Add("Seafood");
            foodcategory1.Add("Greek");
            foodcategory1.Add("Chinese");
            foodcategory1.Add("Spanish");
            foodcategory1.Add("Thai");
            foodcategory1.Add("Asian");

            foodcategory1.Add("Poultry");
            foodcategory1.Add("Dessert");
            foodcategory1.Add("Meat");
            foodcategory1.Add("Breads");
            foodcategory1.Add("Meal");

            foodcategory1.Add("Vegetables");
            foodcategory1.Add("Rice & Grains");
            foodcategory1.Add("Fruits");
            foodcategory1.Add("Snacks");
            foodcategory1.Add("Dairy");

            foodcategory1.Add("Condiments");
            foodcategory1.Add("Pasta");
            foodcategory1.Add("Quick & Easy");
            foodcategory1.Add("Healthy");

            pk_foodcategory1.ItemsSource = foodcategory1;
            lbl_foodcategory1.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_foodcategory1));

            pk_foodcategory2.ItemsSource = foodcategory1;
            lbl_foodcategory2.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_foodcategory2));

            pk_foodcategory3.ItemsSource = foodcategory1;
            lbl_foodcategory3.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_foodcategory3));

            pk_foodcategory4.ItemsSource = foodcategory1;
            lbl_foodcategory4.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_foodcategory4));

            var foodprep = new List<string>();
            foodprep.Add("Baked");
            foodprep.Add("Grilled");
            foodprep.Add("Roasted");
            foodprep.Add("Sauteed");
            foodprep.Add("Stir-fried");
            foodprep.Add("Steamed");
            foodprep.Add("Stewed");
            foodprep.Add("Microwaved");
            foodprep.Add("No-cook");

            pk_foodprep.ItemsSource = foodprep;
            lbl_foodprep.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_foodprep));

            pk_foodcategory1.IsVisible = false;
            pk_foodcategory2.IsVisible = false;
            pk_foodcategory3.IsVisible = false;
            pk_foodcategory4.IsVisible = false;
            pk_foodprep.IsVisible = false;

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

            lbl_activities.IsVisible = false;
            lbl_foodcategory1.IsVisible = false;
            lbl_foodcategory2.IsVisible = false;
            lbl_foodcategory3.IsVisible = false;
            lbl_foodcategory4.IsVisible = false;
            lbl_foodprep.IsVisible = false;
        }
        private async void Finish_Clicked(object sender, EventArgs e)
        {
            userID = generateUserID();

            string activities = pk_activities.SelectedItem.ToString();
            string foodcategory1 = pk_foodcategory1.SelectedItem.ToString();
            string foodcategory2 = pk_foodcategory2.SelectedItem.ToString();
            string foodcategory3 = pk_foodcategory3.SelectedItem.ToString();
            string foodcategory4 = pk_foodcategory4.SelectedItem.ToString();
            string foodprep = pk_foodprep.SelectedItem.ToString();

            userInfoModel user = new userInfoModel();
            user.UserID = userID;
            user.Email = UserInfoPage.email;
            user.Username = UserInfoPage.username;
            user.Lastname = UserInfoPage.lastname;
            user.Firstname = UserInfoPage.firstname;
            user.Birthdate = UserInfoPage.birthdate;
            user.Age = UserInfoPage.age;

            user.Allergies = UserPropertiesPage.allergies;
            user.DietType = UserPropertiesPage.diettype;
            user.Lifestyle = UserPropertiesPage.lifestyle;
            user.HomeCook = UserPropertiesPage.homecook;
            user.CookingFrequency = UserPropertiesPage.cookingfrequency;
            user.CookTime = UserPropertiesPage.cooktime;
            user.CookingSkill = UserPropertiesPage.cookingskill;

            user.Activities = activities;
            user.FoodCategory1 = foodcategory1;
            user.FoodCategory2 = foodcategory2;
            user.FoodCategory3 = foodcategory3;
            user.FoodCategory4 = foodcategory4;
            user.FoodPrep = foodprep;

            var response = await DisplayAlert("Confirmation", "Confirm answers?", "Confirm", "Not yet");
            if (response == true)
            {
                var isSaved = await repository.Save(user);
                    if (isSaved)
                    {
                        await DisplayAlert("Information", "User Info saved!", "Ok");
                        await Navigation.PushAsync(new WelcomePage());
                    }
                    else
                    {
                        await DisplayAlert("Error", "Failed to save user info!", "Ok");
                    }
            }
            else
            {
                await DisplayAlert("Error", "Failed to save user info!", "Ok");
            }
        }
        public string generateUserID()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
        }
        private void picker1show()
        {
            lbl00.IsVisible = true;
            lbl01.IsVisible = true;
            pk_activities.IsVisible = true;
        }
        private void picker2show()
        {
            lbl10.IsVisible = true;
            lbl11.IsVisible = true;
            pk_foodcategory1.IsVisible = true;
        }
        private void picker3show()
        {
            lbl20.IsVisible = true;
            lbl21.IsVisible = true;
            pk_foodcategory2.IsVisible = true;
        }
        private void picker4show()
        {
            lbl30.IsVisible = true;
            lbl31.IsVisible = true;
            pk_foodcategory3.IsVisible = true;
        }
        private void picker5show()
        {
            lbl40.IsVisible = true;
            lbl41.IsVisible = true;
            pk_foodcategory4.IsVisible = true;
        }
        private void picker6show()
        {
            lbl50.IsVisible = true;
            lbl51.IsVisible = true;
            pk_foodprep.IsVisible = true;
        }

        private void btnshow1(object sender, EventArgs e)
        {
            lbl_activities.IsVisible = true;
        }
        private void btnshow2(object sender, EventArgs e)
        {
            lbl_foodcategory1.IsVisible = true;
        }
        private void btnshow3(object sender, EventArgs e)
        {
            lbl_foodcategory2.IsVisible = true;
        }
        private void btnshow4(object sender, EventArgs e)
        {
            lbl_foodcategory3.IsVisible = true;
        }
        private void btnshow5(object sender, EventArgs e)
        {
            lbl_foodcategory4.IsVisible = true;
        }
        private void btnshow6(object sender, EventArgs e)
        {
            lbl_foodprep.IsVisible = true;
        }

        private void pickerhide1_Clicked(object sender, EventArgs e)
        {
            picker1show();
            var btn = (Button)sender;
            pk_foodcategory1.IsVisible = false;
            pk_foodcategory2.IsVisible = false;
            pk_foodcategory3.IsVisible = false;
            pk_foodcategory4.IsVisible = false;
            pk_foodprep.IsVisible = false;

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
        }
        private void pickerhide2_Clicked(object sender, EventArgs e)
        {
            picker2show();
            var btn = (Button)sender;
            pk_activities.IsVisible = false;
            pk_foodcategory2.IsVisible = false;
            pk_foodcategory3.IsVisible = false;
            pk_foodcategory4.IsVisible = false;
            pk_foodprep.IsVisible = false;

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
        }
        private void pickerhide3_Clicked(object sender, EventArgs e)
        {
            picker3show();
            var btn = (Button)sender;
            pk_activities.IsVisible = false;
            pk_foodcategory1.IsVisible = false;
            pk_foodcategory3.IsVisible = false;
            pk_foodcategory4.IsVisible = false;
            pk_foodprep.IsVisible = false;

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
        }
        private void pickerhide4_Clicked(object sender, EventArgs e)
        {
            picker4show();
            var btn = (Button)sender;
            pk_activities.IsVisible = false;
            pk_foodcategory1.IsVisible = false;
            pk_foodcategory2.IsVisible = false;
            pk_foodcategory4.IsVisible = false;
            pk_foodprep.IsVisible = false;

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
        }
        private void pickerhide5_Clicked(object sender, EventArgs e)
        {
            picker5show();
            var btn = (Button)sender;
            pk_activities.IsVisible = false;
            pk_foodcategory1.IsVisible = false;
            pk_foodcategory2.IsVisible = false;
            pk_foodcategory3.IsVisible = false;
            pk_foodprep.IsVisible = false;

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
        }
        private void pickerhide6_Clicked(object sender, EventArgs e)
        {
            picker6show();
            var btn = (Button)sender;
            pk_activities.IsVisible = false;
            pk_foodcategory1.IsVisible = false;
            pk_foodcategory2.IsVisible = false;
            pk_foodcategory3.IsVisible = false;
            pk_foodcategory4.IsVisible = false;

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
        }
    }
}