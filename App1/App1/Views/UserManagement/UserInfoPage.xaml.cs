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
    public partial class UserInfoPage : ContentPage
    {
        public UserInfoPage()
        {
            InitializeComponent();
            txt_userEmail.Text = $"{Application.Current.Properties["userEmail"].ToString()}";
        }
        private async void Next_Clicked(object sender, EventArgs e)
        {
            try
            {
                string username = txt_username.Text;
                string lastname = txt_lastname.Text;
                string firstname = txt_firstname.Text;
                string age = txt_age.Text;

                if (String.IsNullOrEmpty(username))
                {
                    await DisplayAlert("Warning", "Username is required", "Ok");
                    return;
                }
                if (String.IsNullOrEmpty(lastname))
                {
                    await DisplayAlert("Warning", "Last Name is required", "Ok");
                    return;
                }
                if (String.IsNullOrEmpty(firstname))
                {
                    await DisplayAlert("Warning", "First Name is required", "Ok");
                    return;
                }
                if (String.IsNullOrEmpty(age))
                {
                    await DisplayAlert("Warning", "Age is required", "Ok");
                    return;
                }

                await Navigation.PushAsync(new UserPropertiesPage());
                Application.Current.Properties["username"] = txt_username.Text;
            }
            catch 
            { 

            }
        }
    }
}