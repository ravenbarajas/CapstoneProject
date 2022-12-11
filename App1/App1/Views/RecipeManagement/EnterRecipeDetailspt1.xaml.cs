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
        public static string recipeTotalTime;
        public static string prepprocess;
        public static string recipeCategory;
        public static string recipeKeywords;
        public static string recipeKeyword1;
        public static string recipeKeyword2;
        public static string recipeKeyword3;
        public static string recipeKeyword4;
        public static string recipeKeyword5;
        public static string recipeKeyword6;
        public EnterRecipeDetailspt1()
        {
            InitializeComponent();

            var PrepProcess = new List<string>();
            PrepProcess.Add("Baked");
            PrepProcess.Add("Grilled");
            PrepProcess.Add("Roasted");
            PrepProcess.Add("Sauteed");
            PrepProcess.Add("Stir-fried");
            PrepProcess.Add("Steamed");
            PrepProcess.Add("Stewed");
            PrepProcess.Add("Microwaved");
            PrepProcess.Add("No-cook");

            pk_prepprocess.ItemsSource = PrepProcess;
            //lbl_allergies.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_prepprocess));

            var recipecategory = new List<string>();
            recipecategory.Add("Mexican");
            recipecategory.Add("Japanese");
            recipecategory.Add("Seafood");
            recipecategory.Add("Greek");
            recipecategory.Add("Chinese");
            recipecategory.Add("Spanish");
            recipecategory.Add("Thai");
            recipecategory.Add("Asian");

            recipecategory.Add("Poultry");
            recipecategory.Add("Dessert");
            recipecategory.Add("Meat");
            recipecategory.Add("Breads");
            recipecategory.Add("Meal");

            recipecategory.Add("Vegetables");
            recipecategory.Add("Rice & Grains");
            recipecategory.Add("Fruits");
            recipecategory.Add("Snacks");
            recipecategory.Add("Dairy");

            recipecategory.Add("Condiments");
            recipecategory.Add("Pasta");
            recipecategory.Add("Quick & Easy");
            recipecategory.Add("Healthy");

            pk_recipecategory.ItemsSource = recipecategory;
            //lbl_recipekeyword1.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_recipecategory));

            var recipekeyword = new List<string>();
            recipekeyword.Add("Easy");
            recipekeyword.Add("Meat");
            recipekeyword.Add("Vegetable");
            recipekeyword.Add("Healthy");
            recipekeyword.Add("Low Cholesterol");
            recipekeyword.Add("Low Protein");
            recipekeyword.Add("Oven");
            recipekeyword.Add("Beginner Cook");
            recipekeyword.Add("Poultry");
            recipekeyword.Add("European");
            recipekeyword.Add("Fruit");
            recipekeyword.Add("Brunch");
            recipekeyword.Add("Stove Top");
            recipekeyword.Add("Weeknight");
            recipekeyword.Add("Chicken");
            recipekeyword.Add("High In...");
            recipekeyword.Add("Dessert");
            recipekeyword.Add("Breads");
            recipekeyword.Add("Cookie & Brownie");
            recipekeyword.Add("Cheese");
            recipekeyword.Add("Very Low Carbs");
            recipekeyword.Add("High Protein");
            recipekeyword.Add("Savory");
            recipekeyword.Add("Free Of...");
            recipekeyword.Add("Asian");
            recipekeyword.Add("Vegan");
            recipekeyword.Add("Pork");
            recipekeyword.Add("Potato");
            recipekeyword.Add("Summer");
            recipekeyword.Add("Rice");
            recipekeyword.Add("Sweet");
            recipekeyword.Add("Apple");
            recipekeyword.Add("Beans");
            recipekeyword.Add("Mexican");
            recipekeyword.Add("Breakfast");
            recipekeyword.Add("Lunch/Snacks");
            recipekeyword.Add("Grains");
            recipekeyword.Add("Berries");
            recipekeyword.Add("Spicy");
            recipekeyword.Add("Tropical Fruits");
            recipekeyword.Add("Christmas");
            recipekeyword.Add("Onions");
            recipekeyword.Add("Egg Free");
            recipekeyword.Add("Greens");
            recipekeyword.Add("Microwave");
            recipekeyword.Add("Lactose Free");
            recipekeyword.Add("Citrus");
            recipekeyword.Add("Quick Breads");
            recipekeyword.Add("Peppers");
            recipekeyword.Add("Refrigerator");
            recipekeyword.Add("Chicken Breast");
            recipekeyword.Add("Chinese");
            recipekeyword.Add("Broil/Grill");
            recipekeyword.Add("Spanish");
            recipekeyword.Add("Stir Fry");
            recipekeyword.Add("Spaghetti");
            recipekeyword.Add("Lemon");
            recipekeyword.Add("Strawberry");
            recipekeyword.Add("Corn");
            recipekeyword.Add("Roast");
            recipekeyword.Add("Thai");
            recipekeyword.Add("Tuna");
            recipekeyword.Add("Long Grain Rice");
            recipekeyword.Add("Ham");
            recipekeyword.Add("Coconut");
            recipekeyword.Add("Pineapple");
            recipekeyword.Add("Pears");
            recipekeyword.Add("No Cook");
            recipekeyword.Add("Deep Fried");
            recipekeyword.Add("One Dish Meal");
            recipekeyword.Add("Japanese");
            recipekeyword.Add("Cauliflower");
            recipekeyword.Add("Black Beans");
            recipekeyword.Add("Spinach");
            recipekeyword.Add("Penne");
            recipekeyword.Add("Lentil");
            recipekeyword.Add("Freezer");
            recipekeyword.Add("Crab");
            recipekeyword.Add("Soy/Tofu");
            recipekeyword.Add("Lamb/Sheep");
            recipekeyword.Add("Lime");
            recipekeyword.Add("Hawaiian");
            recipekeyword.Add("Yam/Sweet Potato");
            recipekeyword.Add("Whole Chicken");
            recipekeyword.Add("Steam");
            recipekeyword.Add("Roast Beef");
            recipekeyword.Add("Cherries");
            recipekeyword.Add("Oranges");
            recipekeyword.Add("Korean");
            recipekeyword.Add("Steak");
            recipekeyword.Add("Pasta Shells");
            recipekeyword.Add("Melons");
            recipekeyword.Add("Mango");
            recipekeyword.Add("Mussels");
            recipekeyword.Add("Grapes");
            recipekeyword.Add("Filipino");
            recipekeyword.Add("Oysters");
            recipekeyword.Add("Lobster");
            recipekeyword.Add("Cheesecake");
            recipekeyword.Add("Chocolate Chip Cookies");
            recipekeyword.Add("Frozen Desserts");
            recipekeyword.Add("Dairy Free Foods");
            recipekeyword.Add("Candy");
            recipekeyword.Add("Pie");
            recipekeyword.Add("Chowders");
            recipekeyword.Add("Stew");
            recipekeyword.Add("Stocks");
            recipekeyword.Add("Avocado");
            recipekeyword.Add("Papaya");
            recipekeyword.Add("< 4 Hours");
            recipekeyword.Add("< 60 Mins");
            recipekeyword.Add("< 30 Mins");
            recipekeyword.Add("< 15 Mins");

            pk_RK002.ItemsSource = recipekeyword;
            lbl_recipekeyword1.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_RK002));

            pk_RK102.ItemsSource = recipekeyword;
            lbl_recipekeyword2.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_RK102));

            pk_RK202.ItemsSource = recipekeyword;
            lbl_recipekeyword3.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_RK202));

            pk_RK302.ItemsSource = recipekeyword;
            lbl_recipekeyword4.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_RK302));

            pk_RK402.ItemsSource = recipekeyword;
            lbl_recipekeyword5.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_RK402));

            pk_RK502.ItemsSource = recipekeyword;
            lbl_recipekeyword6.SetBinding(Label.TextProperty, new Binding("SeletedItem", source: pk_RK502));

            pk_RK102.IsVisible = false;
            pk_RK202.IsVisible = false;
            pk_RK302.IsVisible = false;
            pk_RK402.IsVisible = false;
            pk_RK502.IsVisible = false;

            RK100.IsVisible = false;
            RK101.IsVisible = false;

            RK200.IsVisible = false;
            RK201.IsVisible = false;

            RK300.IsVisible = false;
            RK301.IsVisible = false;

            RK400.IsVisible = false;
            RK401.IsVisible = false;

            RK500.IsVisible = false;
            RK501.IsVisible = false;

            lbl_recipekeyword1.IsVisible = false;
            lbl_recipekeyword2.IsVisible = false;
            lbl_recipekeyword3.IsVisible = false;
            lbl_recipekeyword4.IsVisible = false;
            lbl_recipekeyword5.IsVisible = false;
            lbl_recipekeyword6.IsVisible = false;
        }
        private async void Next_Clicked(object sender, EventArgs e)
        {
            try
            {
                recipeCookTime = txt_cooktimehr.Text + "Hrs " + txt_cooktimemin.Text + "Mins";
                recipePrepTime = txt_preptimehr.Text + "Hrs " + txt_preptimemin.Text + "Mins";
                recipeTotalTime = lbl_totaltimehr.Text + "Hrs " + lbl_totaltimemin.Text + "Mins";
                recipeCategory = pk_recipecategory.SelectedItem.ToString();
                recipeKeyword1 = "'" + pk_RK002.SelectedItem.ToString() + "'";
                recipeKeyword2 = "'" + pk_RK102.SelectedItem.ToString() + "'";
                recipeKeyword3 = "'" + pk_RK202.SelectedItem.ToString() + "'";
                recipeKeyword4 = "'" + pk_RK302.SelectedItem.ToString() + "'";
                recipeKeyword5 = "'" + pk_RK402.SelectedItem.ToString() + "'";
                recipeKeyword6 = "'" + pk_RK502.SelectedItem.ToString() + "'";
                recipeKeywords = "[" + recipeKeyword1 + ","+ recipeKeyword2 + "," + recipeKeyword3 + "," + recipeKeyword4 + "," + recipeKeyword5 + "," + recipeKeyword6 + "]";

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
                if (String.IsNullOrEmpty(recipeCategory))
                {
                    await DisplayAlert("Warning", "Recipe category is required", "Ok");
                    return;
                }

                if (String.IsNullOrEmpty(recipeKeyword1))
                {
                    await DisplayAlert("Warning", "6 Keywords is required", "Ok");
                    return;
                }
                if (String.IsNullOrEmpty(recipeKeyword2))
                {
                    await DisplayAlert("Warning", "6 Keywords is required", "Ok");
                    return;
                }
                if (String.IsNullOrEmpty(recipeKeyword3))
                {
                    await DisplayAlert("Warning", "6 Keywords is required", "Ok");
                    return;
                }
                if (String.IsNullOrEmpty(recipeKeyword4))
                {
                    await DisplayAlert("Warning", "6 Keywords is required", "Ok");
                    return;
                }
                if (String.IsNullOrEmpty(recipeKeyword5))
                {
                    await DisplayAlert("Warning", "6 Keywords is required", "Ok");
                    return;
                }
                if (String.IsNullOrEmpty(recipeKeyword6))
                {
                    await DisplayAlert("Warning", "6 Keywords is required", "Ok");
                    return;
                }

                await Navigation.PushAsync(new EnterRecipeDetailspt2());
            }
            catch
            { 
            
            }
        }
        private void SumHrTime()
        {
            var hrval1 = int.Parse(txt_cooktimehr.Text);
            var hrval2 = int.Parse(txt_preptimehr.Text);

            // add them
            var hrsum = hrval1 + hrval2;
            lbl_totaltimehr.Text = hrsum.ToString();
        }
        private void SumMinTime()
        {
            var minval1 = int.Parse(txt_cooktimemin.Text);
            var minval2 = int.Parse(txt_preptimemin.Text);

            // add them
            var minsum = minval1 + minval2;
            lbl_totaltimemin.Text = minsum.ToString();
        }
        private void txt_preptimemin_Unfocused(object sender, FocusEventArgs e)
        {
            SumMinTime();
            SumHrTime();
            lbl_totaltimehrlabel.IsVisible = true;
            lbl_totaltimeminlabel.IsVisible = true;
        }

        private void picker1show()
        {
            RK000.IsVisible = true;
            RK001.IsVisible = true;
            pk_RK002.IsVisible = true;
        }
        private void picker2show()
        {
            RK100.IsVisible = true;
            RK101.IsVisible = true;
            pk_RK102.IsVisible = true;
        }
        private void picker3show()
        {
            RK200.IsVisible = true;
            RK201.IsVisible = true;
            pk_RK202.IsVisible = true;
        }
        private void picker4show()
        {
            RK300.IsVisible = true;
            RK301.IsVisible = true;
            pk_RK302.IsVisible = true;
        }
        private void picker5show()
        {
            RK400.IsVisible = true;
            RK401.IsVisible = true;
            pk_RK402.IsVisible = true;
        }
        private void picker6show()
        {
            RK500.IsVisible = true;
            RK501.IsVisible = true;
            pk_RK502.IsVisible = true;
        }

        private void pickerhide1_Clicked(object sender, EventArgs e)
        {
            picker1show();
            var btn = (Button)sender;
            pk_RK102.IsVisible = false;
            pk_RK202.IsVisible = false;
            pk_RK302.IsVisible = false;
            pk_RK402.IsVisible = false;
            pk_RK502.IsVisible = false;

            RK100.IsVisible = false;
            RK101.IsVisible = false;

            RK200.IsVisible = false;
            RK201.IsVisible = false;

            RK300.IsVisible = false;
            RK301.IsVisible = false;

            RK400.IsVisible = false;
            RK401.IsVisible = false;

            RK500.IsVisible = false;
            RK501.IsVisible = false;

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
            pk_RK002.IsVisible = false;
            pk_RK202.IsVisible = false;
            pk_RK302.IsVisible = false;
            pk_RK402.IsVisible = false;
            pk_RK502.IsVisible = false;

            RK000.IsVisible = false;
            RK001.IsVisible = false;

            RK200.IsVisible = false;
            RK201.IsVisible = false;

            RK300.IsVisible = false;
            RK301.IsVisible = false;

            RK400.IsVisible = false;
            RK401.IsVisible = false;

            RK500.IsVisible = false;
            RK501.IsVisible = false;

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
            pk_RK002.IsVisible = false;
            pk_RK102.IsVisible = false;
            pk_RK302.IsVisible = false;
            pk_RK402.IsVisible = false;
            pk_RK502.IsVisible = false;

            RK000.IsVisible = false;
            RK001.IsVisible = false;

            RK100.IsVisible = false;
            RK101.IsVisible = false;

            RK300.IsVisible = false;
            RK301.IsVisible = false;

            RK400.IsVisible = false;
            RK401.IsVisible = false;

            RK500.IsVisible = false;
            RK501.IsVisible = false;

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
            pk_RK002.IsVisible = false;
            pk_RK102.IsVisible = false;
            pk_RK202.IsVisible = false;
            pk_RK402.IsVisible = false;
            pk_RK502.IsVisible = false;

            RK000.IsVisible = false;
            RK001.IsVisible = false;

            RK100.IsVisible = false;
            RK101.IsVisible = false;

            RK200.IsVisible = false;
            RK201.IsVisible = false;

            RK400.IsVisible = false;
            RK401.IsVisible = false;

            RK500.IsVisible = false;
            RK501.IsVisible = false;

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
            pk_RK002.IsVisible = false;
            pk_RK102.IsVisible = false;
            pk_RK202.IsVisible = false;
            pk_RK302.IsVisible = false;
            pk_RK502.IsVisible = false;

            RK000.IsVisible = false;
            RK001.IsVisible = false;

            RK100.IsVisible = false;
            RK101.IsVisible = false;

            RK200.IsVisible = false;
            RK201.IsVisible = false;

            RK300.IsVisible = false;
            RK301.IsVisible = false;

            RK500.IsVisible = false;
            RK501.IsVisible = false;

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
            pk_RK002.IsVisible = false;
            pk_RK102.IsVisible = false;
            pk_RK202.IsVisible = false;
            pk_RK302.IsVisible = false;
            pk_RK402.IsVisible = false;

            RK000.IsVisible = false;
            RK001.IsVisible = false;

            RK100.IsVisible = false;
            RK101.IsVisible = false;

            RK200.IsVisible = false;
            RK201.IsVisible = false;

            RK300.IsVisible = false;
            RK301.IsVisible = false;

            RK400.IsVisible = false;
            RK401.IsVisible = false;

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

        private void btnshow1(object sender, EventArgs e)
        {
            lbl_recipekeyword1.IsVisible = true;
        }
        private void btnshow2(object sender, EventArgs e)
        {
            lbl_recipekeyword2.IsVisible = true;
        }
        private void btnshow3(object sender, EventArgs e)
        {
            lbl_recipekeyword3.IsVisible = true;
        }
        private void btnshow4(object sender, EventArgs e)
        {
            lbl_recipekeyword4.IsVisible = true;
        }
        private void btnshow5(object sender, EventArgs e)
        {
            lbl_recipekeyword5.IsVisible = true;
        }
        private void btnshow6(object sender, EventArgs e)
        {
            lbl_recipekeyword6.IsVisible = true;
        }
    }
}