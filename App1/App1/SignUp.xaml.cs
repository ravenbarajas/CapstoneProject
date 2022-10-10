using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUp : ContentPage
    {
        firebaseConnection connection = new firebaseConnection();
        userInfo authenticateAcc = new userInfo();
        public SignUp()
        {
            InitializeComponent();
        }

        private async void ButtonClicked(object sender, EventArgs e)
        {
           try
            { 
            string username = Username.Text;
            string phone = PhoneNum.Text;
            string pass = Password.Text;

            userInfo user = new userInfo();
            user.Username = username;
            user.PhoneNum = phone;
            user.Pass = pass;

            var isSaved = await connection.Save(user);
            //bool isSave = await authenticateAcc.Register(email, lastName, password);

                if (isSaved)
                {
                    await DisplayAlert("Information", "Signup Success!", "Ok");
                    await Navigation.PushAsync(new Privacy_Policy());
                }
                else
                {
                    await DisplayAlert("Error", "Error! Signup Failed!", "Ok");
                }
            }
            catch (Exception exception)
            {
                if (exception.Message.Contains("EMAIL_EXISTS"))
                {

                    await DisplayAlert("Sign In", "Field Empty! Please try again", "OK");
                }
                else exception.Message.Contains("INVALID_EMAIL");
                {
                    await DisplayAlert("Invalid Email", "Email is Invalid. Please try again!", "OK");
                }
            }
        }
    }
}