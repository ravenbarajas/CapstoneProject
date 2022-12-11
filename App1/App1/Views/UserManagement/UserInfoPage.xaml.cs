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
        userInfo repository = new userInfo();

        public static string username;
        public static string email;
        public static string lastname;
        public static string firstname;
        public static string birthdate;
        public static string age;

        public UserInfoPage()
        {
            InitializeComponent();
            txt_username.Text = $"{Application.Current.Properties["username"].ToString()}";
            txt_userEmail.Text = $"{Application.Current.Properties["userEmail"].ToString()}";
        }
        private async void Next_Clicked(object sender, EventArgs e)
        {
            try
            {
                username = txt_username.Text;
                email = txt_userEmail.Text;
                lastname = txt_lastname.Text;
                firstname = txt_firstname.Text;
                birthdate = dp_birthdate.Date.ToString("MM/dd/yyyy");
                age = txt_age.Text;

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
            }
            catch 
            { 

            }
        }
        public void clear()
        {
            txt_userEmail.Text = string.Empty;
            txt_username.Text = string.Empty;
            txt_lastname.Text = string.Empty;
            txt_firstname.Text = string.Empty;
            txt_age.Text = string.Empty;
        }
        public string generateUserID()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
        }
    }
}