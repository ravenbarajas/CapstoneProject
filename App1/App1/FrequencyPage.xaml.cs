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
    public partial class FrequencyPage : ContentPage
    {
        public FrequencyPage()
        {
            InitializeComponent();
        }
        private async void Page3to4_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new FavoriteDishPage());
        }
    }
}