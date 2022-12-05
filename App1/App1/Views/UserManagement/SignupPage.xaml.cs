using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Firebase.Auth;

namespace App1.Views.UserManagement
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupPage : ContentPage
    {
        firebaseConnection connection = new firebaseConnection();
        userInfo authenticateAcc = new userInfo();

        public string email;

        userAuth _userAuth = new userAuth();
        public SignupPage()
        {
            InitializeComponent();
        }

        private async void ButtonClicked(object sender, EventArgs e)
        {
            try
            {
                string email = Email.Text;
                string pass = Password.Text;

                if (String.IsNullOrEmpty(email))
                {
                    await DisplayAlert("Warning", "Email is required", "Ok");
                    return;
                }
                if (pass.Length <= 6)
                {
                    await DisplayAlert("Warning", "Strong Password is required", "Ok");
                    return;
                }
                if (String.IsNullOrEmpty(pass))
                {
                    await DisplayAlert("Warning", "Password is required", "Ok");
                    return;
                }

                bool isSave = await _userAuth.Register(email, pass);
                if (isSave)
                {
                    Application.Current.Properties["userEmail"] = Email.Text;
                    await DisplayAlert("Signup", "Registration Completed", "Ok");
                    await Navigation.PushAsync(new UserInfoPage());
                }
                else
                {
                    await DisplayAlert("Registration", "Registration Failed", "Ok");
                }
            }
            catch (Exception exception)
            {
                if (exception.Message.Contains("EMAIL_EXISTS"))
                {
                    await DisplayAlert("Warning", "Email already exist!", "Ok");
                    Email.Text = "";
                    Password.Text = "";
                }
                else
                {
                    await DisplayAlert("Error", "Invalid Email. Please enter a valid email!", "Ok");
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
            Navigation.PushAsync(new Views.UserManagement.LoginPage());
        }
    }
}