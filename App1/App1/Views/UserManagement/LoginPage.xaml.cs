using App1.Views.RecipePresentation;
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
    public partial class LoginPage : ContentPage
    {
        userAuth _userAuth = new userAuth();
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                string email = Email.Text;
                string pass = Password.Text;
                string token = await _userAuth.SignIn(email, pass);

                if (String.IsNullOrEmpty(email))
                {
                    await DisplayAlert("Warning", "Email is required", "Ok");
                    return;
                }
                if (String.IsNullOrEmpty(pass))
                {
                    await DisplayAlert("Warning", "Password is required", "Ok");
                    return;
                }
                if (!string.IsNullOrEmpty(token))
                {
                    await Navigation.PushAsync(new HomePage());
                }
                else
                {
                    await DisplayAlert("Sign In", "Sign In failed!", "Try again");
                }
            }
            catch (Exception exception)
            {
                if (exception.Message.Contains("EMAIL_NOT_FOUND"))
                {
                    await DisplayAlert("Unauthorized", "Sign In failed! Email not found", "Try again");
                    Email.Text = "";
                    Password.Text = "";
                }
                else if (exception.Message.Contains("INVALID_PASSWORD"))
                {
                    await DisplayAlert("Unauthorized", "Sign In failed! Incorrect password", "Try again");
                    Email.Text = "";
                    Password.Text = "";
                }
                else 
                {
                    await DisplayAlert("Error", exception.Message, "Ok");
                }
            }
        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            var imageButton = sender as ImageButton;
            if (Password.IsPassword)
            {
                imageButton.Source = ImageSource.FromFile("show.png");
                Password.IsPassword = false;
            }
            else
            {
                imageButton.Source = ImageSource.FromFile("hide.png");
                Password.IsPassword = true;
            }
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.UserManagement.SignupPage());
        }
    }
}