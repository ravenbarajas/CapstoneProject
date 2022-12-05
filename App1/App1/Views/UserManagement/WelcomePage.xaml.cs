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
    public partial class WelcomePage : ContentPage
    {
        public static string username;
        public WelcomePage()
        {
            InitializeComponent();
            lbl_welcomeUser.Text = UserInfoPage.username;
        }
        private async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}
