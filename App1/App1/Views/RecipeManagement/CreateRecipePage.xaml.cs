using App1.Views.RecipeGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.RecipeManagement
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateRecipePage : ContentPage
    {

        recipeInfo repository = new recipeInfo();

        public static string recipeName;
        public static string recipeDesc;
        public CreateRecipePage()
        {
            InitializeComponent();
        }
        private async void btn_Clicked(object sender, EventArgs e)
        {
            double _scale = 0;
            _scale = gridImageOption.Scale;
            sl.IsEnabled = false;
            await gridImageOption.ScaleTo(0, 500);
            gridImageOption.IsVisible = true;
            await gridImageOption.ScaleTo(_scale, 300);
        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {
            CloseDialog();
        }

        private void CloseDialog()
        {
            sl.IsEnabled = true;
            gridImageOption.IsVisible = false;
        }

        private async void ctrlCamera_Tapped(object sender, EventArgs e)
        {
            try
            {
                var result = await MediaPicker.CapturePhotoAsync();

                if (result != null)
                {
                    var stream = await result.OpenReadAsync();

                    img.Source = ImageSource.FromStream(() => stream);
                }
                CloseDialog();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Demo", ex.Message, "OK");
            }
        }

        private async void ctrlGallery_Tapped(object sender, EventArgs e)
        {
            try
            {
                var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
                {
                    Title = "Please pick a photo"
                });

                if (result != null)
                {
                    var stream = await result.OpenReadAsync();

                    img.Source = ImageSource.FromStream(() => stream);
                }
                CloseDialog();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Demo", ex.Message, "OK");
            }
        }
        private async void Next_Clicked(object sender, EventArgs e)
        {
            try
            {
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
    }
}