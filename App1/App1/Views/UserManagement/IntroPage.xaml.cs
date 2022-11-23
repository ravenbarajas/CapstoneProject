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
    public partial class IntroPage : CarouselPage
    {
        public IntroPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.UserManagement.PrivacyPolicyPage());
        }

        private async void Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.UserManagement.LoginPage());
        }
    }
}