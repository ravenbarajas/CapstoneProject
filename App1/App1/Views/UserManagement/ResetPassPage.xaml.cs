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
    public partial class ResetPassPage : ContentPage
    {
        userAuth _userAuth = new userAuth();
        public ResetPassPage()
        {
            InitializeComponent();
        }

        private async void SendLink_Clicked(object sender, EventArgs e)
        {
            string email = txt_EnterEmail.Text;
            if (string.IsNullOrEmpty(email))
            {
                await DisplayAlert("Warning", "Please enter your email.", "Ok");
                return;
            }

            bool isSend = await _userAuth.ResetPassword(email);
            if (isSend)
            {
                await DisplayAlert("Reset Password", "Link sent to your email.", "Ok");
                await Navigation.PopModalAsync();
            }
            else
            {
                await DisplayAlert("Reset Password", "Link send failed.", "Ok");
            }

        }
    }
}