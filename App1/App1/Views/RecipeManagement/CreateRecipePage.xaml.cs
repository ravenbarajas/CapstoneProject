using App1.Views.RecipeGeneration;
using App1.Views.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Essentials;
using Firebase.Storage;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System.IO;

namespace App1.Views.RecipeManagement
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateRecipePage : ContentPage
    {
        MediaFile file;
        recipeInfo recipeRepository = new recipeInfo();

        public static string image;
        public static string recipeID;
        public static string recipeAuthorName;
        public static string recipeName;
        public static string recipeDesc;
        public CreateRecipePage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();

        }
        private async void Next_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            try
            {
                recipeInfoModel recipe = new recipeInfoModel();

                recipeAuthorName = txt_username.Text;
                recipeName = txt_recipename.Text;
                recipeDesc = txt_recipedesc.Text;

                if (String.IsNullOrEmpty(recipeName))
                {
                    await DisplayAlert("Warning", "Recipe Name is required", "Ok");
                    return;
                }
                if (String.IsNullOrEmpty(recipeDesc))
                {
                    await DisplayAlert("Warning", "Recipe Description is required", "Ok");
                    return;
                }

                image = await recipeRepository.UploadFile(file.GetStream(), Path.GetFileName(file.Path));

                await Navigation.PushAsync(new EnterRecipeDetailspt1());
            }
            catch
            {

            }
                
        }
        public string generateRecipeID()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
        }
        private async void btn_pickClicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            try
            {
                file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
                {
                    PhotoSize = Plugin.Media.Abstractions.PhotoSize.Full
                });
                if (file == null)
                    return;
                img.Source = ImageSource.FromStream(() =>
                {
                    var imageStram = file.GetStream();
                    return imageStram;
                });
            }
            catch
            {

            }
        }
    }
}