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

        public static string recipeCookTime;
        public static string recipePrepTime;
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
                recipeAuthorName = txt_username.Text;

                recipeName = txt_recipename.Text;
                recipeDesc = txt_recipedesc.Text;

                recipeCookTime = txt_cooktimehr.Text + lbl_cooktimehr.Text + txt_cooktimemin.Text + lbl_cooktimemin.Text;
                recipePrepTime = txt_preptimehr.Text + lbl_preptimehr.Text + txt_preptimemin.Text + lbl_preptimemin.Text;

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

        private void txt_cooktimehr_Completed(object sender, EventArgs e)
        {
            string cooktimehr = txt_cooktimehr.Text;
            int cooktimehrval;
            if (!string.IsNullOrEmpty(cooktimehr) && int.TryParse(cooktimehr, out cooktimehrval))
            {
                
            }
            if (cooktimehr == "1")
            {
                lbl_cooktimehr.Text = " Hour ";
            }
            else if (cooktimehr == "" || cooktimehr =="0")
            {
                lbl_cooktimehr.Text ="";
                txt_cooktimehr.Text ="";
            }
            else
            {
                lbl_cooktimehr.Text = " Hours ";
            }
        }
        private void txt_cooktimemin_Completed(object sender, EventArgs e)
        {
            string cooktimemin = txt_cooktimemin.Text;
            int cooktimeminval;
            if (!string.IsNullOrEmpty(cooktimemin) && int.TryParse(cooktimemin, out cooktimeminval))
            {

            }
            if (cooktimemin == "1")
            {
                lbl_cooktimemin.Text = " Minute";
            }
            else if (cooktimemin == "" || cooktimemin == "0")
            {
                lbl_cooktimemin.Text = "";
                txt_cooktimemin.Text = "";
            }
            else
            {
                lbl_cooktimemin.Text = " Minutes";
            }
        }
        private void txt_preptimehr_Completed(object sender, EventArgs e)
        {
            string preptimehr = txt_preptimehr.Text;
            int preptimehrval;
            if (!string.IsNullOrEmpty(preptimehr) && int.TryParse(preptimehr, out preptimehrval))
            {

            }
            if (preptimehr == "1")
            {
                lbl_preptimehr.Text = " Hour ";
            }
            else if (preptimehr == "" || preptimehr == "0")
            {
                lbl_preptimehr.Text = "";
                txt_preptimehr.Text = "";
            }
            else
            {
                lbl_preptimehr.Text = " Hours ";
            }
        }
        private void txt_preptimemin_Completed(object sender, EventArgs e)
        {
            string preptimemin = txt_preptimemin.Text;
            int preptimeminval;
            if (!string.IsNullOrEmpty(preptimemin) && int.TryParse(preptimemin, out preptimeminval))
            {

            }
            if (preptimemin == "1")
            {
                lbl_preptimemin.Text = " Minute";
            }
            else if (preptimemin == "" || preptimemin == "0")
            {
                lbl_preptimemin.Text = "";
                txt_preptimemin.Text = "";
            }
            else
            {
                lbl_preptimemin.Text = " Minutes";
            }
        }
    }
}