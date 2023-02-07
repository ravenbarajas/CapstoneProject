using App1.Views.RecipeGeneration;
using App1.Views.UserManagement;
using App1.Views.RecipeManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using Firebase.Storage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace App1.Views.RecipePresentation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://capstoneproject-b8d68-default-rtdb.asia-southeast1.firebasedatabase.app/");
        FirebaseStorage firebaseStorage = new FirebaseStorage("capstoneproject-b8d68.appspot.com");

        ObservableCollection<recipeInfoModel> recipes = new ObservableCollection<recipeInfoModel>();
        ObservableCollection<recipeInfoModel> recipes1 = new ObservableCollection<recipeInfoModel>();
        ObservableCollection<recipeInfoModel> recipes2 = new ObservableCollection<recipeInfoModel>();
        ObservableCollection<recipeInfoModel> recipes3 = new ObservableCollection<recipeInfoModel>();
        ObservableCollection<recipeInfoModel> recipes4 = new ObservableCollection<recipeInfoModel>();

        recipeInfo repository = new recipeInfo();
        userInfo userRepo = new userInfo();
        public HomePage()
        {
            InitializeComponent();
            LoadRecipes();
            RandomRecipeListView.RefreshCommand = new Command(() =>
            {
                base.OnAppearing();
            });
        }
        private async void Home_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
        private async void UserProfile_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserProfilePage());
        }
        private async void GenerateRecipe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GenerateRecipePage());
        }
        //private async void Recipe_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new RecipePage());
        //}
        //private void highlightMT()
        //{
        //    MT1.BackgroundColor = Color.FromRgb(127, 132, 135);
        //    MT1.TextColor = Color.White;
        //    MT1.FontAttributes = FontAttributes.None;

        //    MT2.BackgroundColor = Color.FromRgb(127, 132, 135);
        //    MT2.TextColor = Color.White;
        //    MT2.FontAttributes = FontAttributes.None;

        //    MT3.BackgroundColor = Color.FromRgb(127, 132, 135);
        //    MT3.TextColor = Color.White;
        //    MT3.FontAttributes = FontAttributes.None;

        //    MT4.BackgroundColor = Color.FromRgb(127, 132, 135);
        //    MT4.TextColor = Color.White;
        //    MT4.FontAttributes = FontAttributes.None;

        //    MT5.BackgroundColor = Color.FromRgb(127, 132, 135);
        //    MT5.TextColor = Color.White;
        //    MT5.FontAttributes = FontAttributes.None;

        //    MT6.BackgroundColor = Color.FromRgb(127, 132, 135);
        //    MT6.TextColor = Color.White;
        //    MT6.FontAttributes = FontAttributes.None;

        //    MT7.BackgroundColor = Color.FromRgb(127, 132, 135);
        //    MT7.TextColor = Color.White;
        //    MT7.FontAttributes = FontAttributes.None;

        //    MT8.BackgroundColor = Color.FromRgb(127, 132, 135);
        //    MT8.TextColor = Color.White;
        //    MT8.FontAttributes = FontAttributes.None;
        //}
        //private void MT_Clicked(object sender, EventArgs e)
        //{
        //    highlightMT();

        //    var btn = (Button)sender;
        //    btn.BackgroundColor = Color.FromRgb(63, 157, 47);
        //    btn.TextColor = Color.White;
        //    btn.FontAttributes = FontAttributes.Bold;
        //    btn.BorderWidth = 0;
        //}
        private async void RecipeImg_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new RecipeOutputPage());
        }
        private async void LoadRecipes()
        {
            var random = new Random();
            int numberOfRecipes = 170; // Assuming there are 10 recipes in the database

            for (int i = 0; i < 5; i++)
            {
                int randomIndex = random.Next(1, numberOfRecipes + 1);
                var recipe = await firebaseClient
                      .Child(nameof(recipeInfoModel))
                      .Child(randomIndex.ToString())
                      .OnceSingleAsync<recipeInfoModel>();

                switch (i)
                {
                    case 0:
                        recipes.Add(recipe);
                        RandomRecipeListView.ItemsSource = recipes;
                        break;
                    case 1:
                        recipes1.Add(recipe);
                        RandomRecipeListView1.ItemsSource = recipes1;
                        break;
                    case 2:
                        recipes2.Add(recipe);
                        RandomRecipeListView2.ItemsSource = recipes2;
                        break;
                    case 3:
                        recipes3.Add(recipe);
                        RandomRecipeListView3.ItemsSource = recipes3;
                        break;
                    case 4:
                        recipes4.Add(recipe);
                        RandomRecipeListView4.ItemsSource = recipes4;
                        break;
                }
            }
        }
        //private async void LoadUserProfile()
        //{
        //    var userdata = await firebaseClient
        //      .Child(nameof(userInfoModel))
        //      .OnceSingleAsync<userInfoModel>();

        //    user.Add(userdata);
        //    UserInfoListView.ItemsSource = user;
        //}
        protected override async void OnAppearing()
        {
            var ingredient = await repository.GetAll();
            RecipeListView.ItemsSource = null;
            RecipeListView.ItemsSource = ingredient;
            RecipeListView.IsRefreshing = false;
        }
        private void RecipeListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
            {
                return;
            }
            var recipes = e.Item as recipeInfoModel;
            Navigation.PushModalAsync(new RecipeDetailsPage(recipes));
            ((ListView)sender).SelectedItem = null;
        }
        private async void txt_searchrecipesSearchButtonPressed(object sender, EventArgs e)
        {
            string searchValue = txt_searchrecipes.Text;
            if (!String.IsNullOrEmpty(searchValue))
            {
                var recipes = await repository.GetAllByName(searchValue);
                RecipeListView.ItemsSource = null;
                RecipeListView.ItemsSource = recipes;
            }
            else
            {
                OnAppearing();
            }
        }


    }
}