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

namespace App1.Views.UserManagement
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserInfoPage : ContentPage
    {
        MediaFile file;
        userInfo repository = new userInfo();

        public static string userID;
        public static string username;

        public UserInfoPage()
        {
            InitializeComponent();
            txt_username.Text = $"{Application.Current.Properties["username"].ToString()}";
            txt_userEmail.Text = $"{Application.Current.Properties["userEmail"].ToString()}";
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();

        }
        private async void Next_Clicked(object sender, EventArgs e)
        {
            try
            {
                userID = generateUserID();

                username = txt_username.Text;
                string image = await repository.UploadFile(file.GetStream(), Path.GetFileName(file.Path));
                string email = txt_userEmail.Text;
                string lastname = txt_lastname.Text;
                string firstname = txt_firstname.Text;
                string birthdate = dp_birthdate.Date.ToString("MM/dd/yyyy");
                string age = txt_age.Text;

                userInfoModel user = new userInfoModel();
                user.UserIMG = image;
                user.UserID = userID;
                user.Email = email;
                user.Username = username;
                user.Lastname = lastname;
                user.Firstname = firstname;
                user.Birthdate = birthdate;
                user.Age = age;

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

                var response = await DisplayAlert("Confirmation", "Confirm answers?", "Confirm", "Not yet");
                if (response == true)
                {
                    var isSaved = await repository.Save(user);
                    if (isSaved)
                    {
                        await DisplayAlert("Information", "User Info saved!", "Ok");
                        await Navigation.PushAsync(new WelcomePage());
                    }
                    else
                    {
                        await DisplayAlert("Error", "Failed to save user info!", "Ok");
                    }
                }
                else
                {
                    await DisplayAlert("Error", "Failed to save user info!", "Ok");
                }
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
        private void dp_birthdate_DateSelected(object sender, DateChangedEventArgs e)
        {
            int age = 0;

            if (dp_birthdate.Date != null)
            {
                // Calculate the age based on the selected date and the current date
                age = DateTime.Today.Year - dp_birthdate.Date.Year;
                if (dp_birthdate.Date > DateTime.Today.AddYears(-age)) age--;
            }

            txt_age.Text = age.ToString();
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