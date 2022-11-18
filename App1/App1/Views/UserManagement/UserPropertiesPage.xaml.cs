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
    public partial class UserPropertiesPage : ContentPage
    {
        public UserPropertiesPage()
        {
            InitializeComponent();
        }
        private async void UserPropertiesDone_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WelcomePage());
        }

        private async void PreviousButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserInfoPage());
        }
    }
}