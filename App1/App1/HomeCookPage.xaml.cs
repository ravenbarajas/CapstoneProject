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
    public partial class HomeCookPage : ContentPage
    {
        public HomeCookPage()
        {
            InitializeComponent();
        }
        private async void Page2to3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FrequencyPage());
        }
    }
}